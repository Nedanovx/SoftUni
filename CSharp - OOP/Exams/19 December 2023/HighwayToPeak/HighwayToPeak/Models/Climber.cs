using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories;
using HighwayToPeak.Repositories.Contracts;
using HighwayToPeak.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public abstract class Climber : IClimber
    {
        private string name;
        private int stamina;
        private readonly List<string> peaks;

        protected Climber(string name, int stamina)
        {
            Name = name;
            Stamina = stamina;
            peaks = new List<string>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.ClimberNameNullOrWhiteSpace);
                }
                name = value;
            }
        }

        public int Stamina
        {
            get => stamina;
            protected set
            {
                stamina = Math.Max(0, Math.Min(value, 10));
            }
        }

        public IReadOnlyCollection<string> ConqueredPeaks => peaks;

        public void Climb(IPeak peak)
        {
            if(!peaks.Contains(peak.Name))
            {
                peaks.Add(peak.Name);
            }

            switch(peak.DifficultyLevel)
            {
                case "Extreme":
                    Stamina -= 6;
                    break;
                case "Hard":
                    Stamina -= 4;
                    break;
                case "Moderate":
                    Stamina -= 2;
                    break;
            }
        }

        public abstract void Rest(int daysCount);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name} - Name: {Name}, Stamina: {Stamina}");
            if(peaks.Count > 0)
            {
                sb.AppendLine($"Peaks conquered: {peaks.Count}");
            }
            else
            {
                sb.AppendLine("Peaks conquered: no peaks conquered");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
