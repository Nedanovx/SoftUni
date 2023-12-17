using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Repositories.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System.Text;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private IRepository<IDiver> divers;
        private IRepository<IFish> fish;

        public Controller()
        {
            divers = new DiverRepository();
            fish = new FishRepository();
        }
        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            if(divers.GetModel(diverName) == null) 
            {
                return string.Format(OutputMessages.DiverNotFound, nameof(DiverRepository), diverName);
            }

            IDiver diver = divers.GetModel(diverName);

            if(fish.GetModel(fishName) == null)
            {
                return string.Format(OutputMessages.FishNotAllowed, fishName);
            }

            IFish fishToCatch = fish.GetModel(fishName);

            if(diver.HasHealthIssues)
            {
                return string.Format(OutputMessages.DiverHealthCheck, diverName);
            }

            if(diver.OxygenLevel < fishToCatch.TimeToCatch)
            {
                diver.Miss(fishToCatch.TimeToCatch);

                if(diver.OxygenLevel <= 0)
                {
                    diver.UpdateHealthStatus();
                }

                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }
            else if (diver.OxygenLevel == fishToCatch.TimeToCatch)
            {
                if(isLucky)
                {
                    diver.Hit(fishToCatch);
                    if (diver.OxygenLevel <= 0)
                    {
                        diver.UpdateHealthStatus();
                    }
                    return string.Format(OutputMessages.DiverHitsFish, diverName, fishToCatch.Points, fishName);
                }
                else
                {
                    diver.Miss(fishToCatch.TimeToCatch);
                    if (diver.OxygenLevel <= 0)
                    {
                        diver.UpdateHealthStatus();
                    }
                    return string.Format(OutputMessages.DiverMisses, diverName, fishName);
                }
            }
            else
            {
                diver.Hit(fishToCatch);
                if (diver.OxygenLevel <= 0)
                {
                    diver.UpdateHealthStatus();
                }
                return string.Format(OutputMessages.DiverHitsFish, diverName, fishToCatch.Points, fishName);
            }
        }

        public string CompetitionStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Nautical-Catch-Challenge**");
            foreach (var diver in divers.Models.Where(x => x.HasHealthIssues == false)
                .OrderByDescending(x => x.CompetitionPoints)
                .ThenByDescending(x => x.Catch.Count)
                .ThenBy(x => x.Name))
            {
                sb.AppendLine(diver.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if(diverType != nameof(ScubaDiver) && diverType != nameof(FreeDiver))
            {
                return string.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }

            if(divers.GetModel(diverName) != null)
            {
                return string.Format(OutputMessages.DiverNameDuplication, diverName, nameof(DiverRepository));
            }

            IDiver diver;
            if(nameof(FreeDiver) ==  diverType)
            {
                diver = new FreeDiver(diverName);
            }
            else
            {
                diver = new ScubaDiver(diverName);
            }
            divers.AddModel(diver);

            return string.Format(OutputMessages.DiverRegistered, diverName, nameof(DiverRepository));
        }

        public string DiverCatchReport(string diverName)
        {
            StringBuilder sb = new StringBuilder();
            IDiver diver = divers.GetModel(diverName);

            sb.AppendLine(diver.ToString());
            sb.AppendLine("Catch Report:");

            foreach(var fishName in diver.Catch)
            {
                IFish currentFish = fish.GetModel(fishName);
                sb.AppendLine(currentFish.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string HealthRecovery()
        {
            int count = 0;

            foreach(var diver in divers.Models.Where(x => x.HasHealthIssues == true))
            {
                diver.UpdateHealthStatus();
                diver.RenewOxy();
                count++;
            }

            return string.Format(OutputMessages.DiversRecovered, count);
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if(nameof(ReefFish) != fishType && nameof(PredatoryFish) != fishType && nameof(DeepSeaFish) != fishType)
            {
                return string.Format(OutputMessages.FishTypeNotPresented, fishType);
            }

            if(fish.GetModel(fishName) != null)
            {
                return string.Format(OutputMessages.FishNameDuplication, fishName, nameof(FishRepository));
            }

            IFish fishToAdd;
            if(nameof(PredatoryFish) == fishType)
            {
                fishToAdd = new PredatoryFish(fishName, points);
            }
            else if(nameof(ReefFish)  == fishType)
            {
                fishToAdd = new ReefFish(fishName, points);
            }
            else
            {
                fishToAdd = new DeepSeaFish(fishName, points);
            }

            fish.AddModel(fishToAdd);
            return string.Format(OutputMessages.FishCreated, fishName);
        }
    }
}
