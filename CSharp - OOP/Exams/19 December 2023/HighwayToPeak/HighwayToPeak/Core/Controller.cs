using HighwayToPeak.Core.Contracts;
using HighwayToPeak.Models;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories;
using HighwayToPeak.Repositories.Contracts;
using HighwayToPeak.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Core
{
    public class Controller : IController
    {
        private IRepository<IPeak> peaks;
        private IRepository<IClimber> climbers;
        private IBaseCamp camp;
        public Controller() 
        {
            peaks = new PeakRepository();
            climbers = new ClimberRepository();
            camp = new BaseCamp();
        }
        public string AddPeak(string name, int elevation, string difficultyLevel)
        {
            if(peaks.Get(name) != null)
            {
                return string.Format(OutputMessages.PeakAlreadyAdded, name);
            }
            if(difficultyLevel != "Extreme" && difficultyLevel != "Hard" && difficultyLevel != "Moderate") 
            {
                return string.Format(OutputMessages.PeakDiffucultyLevelInvalid, difficultyLevel);
            }
            IPeak peak = new Peak(name, elevation, difficultyLevel);
            peaks.Add(peak);
            return string.Format(OutputMessages.PeakIsAllowed, name, nameof(PeakRepository));
        }

        public string AttackPeak(string climberName, string peakName)
        {
            if(climbers.Get(climberName) == null)
            {
                return string.Format(OutputMessages.ClimberNotArrivedYet, climberName);
            }

            if(peaks.Get(peakName) == null)
            {
                return string.Format(OutputMessages.PeakIsNotAllowed, peakName);
            }
            if(!camp.Residents.Contains(climberName)) 
            {
                return string.Format(OutputMessages.ClimberNotFoundForInstructions, climberName, peakName);
            }
            IPeak peak = peaks.Get(peakName);
            IClimber climber = climbers.Get(climberName);
            if(peak.DifficultyLevel == "Extreme" && climber.GetType().Name == nameof(NaturalClimber))
            {
                return string.Format(OutputMessages.NotCorrespondingDifficultyLevel, climberName, peakName);
            }

            camp.LeaveCamp(climberName);
            climber.Climb(peak);

            if(climber.Stamina <= 0)
            {
                return string.Format(OutputMessages.NotSuccessfullAttack, climberName);
            }
            camp.ArriveAtCamp(climberName);
            return string.Format(OutputMessages.SuccessfulAttack, climberName, peakName);
        }

        public string BaseCampReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BaseCamp residents:");
            if(!camp.Residents.Any() )
            {
                sb.AppendLine("BaseCamp is currently empty.");
            }
            foreach(var climber in camp.Residents)
            {
                foreach(var climberReport in climbers.All.Where(x => x.Name == climber).Distinct())
                {
                    sb.AppendLine($"Name: {climberReport.Name}, Stamina: {climberReport.Stamina}, Count of Conquered Peaks: {climberReport.ConqueredPeaks.Count}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public string CampRecovery(string climberName, int daysToRecover)
        {
            if(!camp.Residents.Contains(climberName))
            {
                return string.Format(OutputMessages.ClimberIsNotAtBaseCamp, climberName);
            }
            IClimber climber = climbers.Get(climberName);

            if(climber.Stamina == 10)
            {
                return string.Format(OutputMessages.NoNeedOfRecovery, climberName);
            }
            climber.Rest(daysToRecover);
            return string.Format(OutputMessages.ClimberRecovered, climberName, daysToRecover);
        }

        public string NewClimberAtCamp(string name, bool isOxygenUsed)
        {
            if(climbers.Get(name) != null)
            {
                return string.Format(OutputMessages.ClimberCannotBeDuplicated, name, nameof(ClimberRepository));
            }
            IClimber climber;

            if (isOxygenUsed)
            {
                climber = new OxygenClimber(name);
            }
            else
            {
                climber = new NaturalClimber(name);
            }
            climbers.Add(climber);
            camp.ArriveAtCamp(name);
            return string.Format(OutputMessages.ClimberArrivedAtBaseCamp, name);
        }

        public string OverallStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***Highway-To-Peak***");
                foreach(var climber in climbers.All.OrderByDescending(x => x.ConqueredPeaks.Count)
                    .ThenBy(x => x.Name))
                {
                    sb.AppendLine(climber.ToString());
                foreach(var peak in peaks.All.OrderByDescending(x => x.Elevation))
                {
                    if(climber.ConqueredPeaks.Contains(peak.Name))
                    {
                        sb.AppendLine(peak.ToString());
                    }
                }
                }

            return sb.ToString().TrimEnd();
        }
    }
}
