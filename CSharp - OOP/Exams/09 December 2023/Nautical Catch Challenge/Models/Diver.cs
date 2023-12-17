using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Diver : IDiver
    {
        private string name;
        private int oxygenLevel;
        private readonly List<string> caughtFish;
        private double competitionPoints;
        private bool isHealthIssues;

        protected Diver(string name, int oxygenLevel) 
        {
            Name = name;
            OxygenLevel = oxygenLevel;
            caughtFish = new List<string>();
            competitionPoints = 0;
            isHealthIssues = false;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.DiversNameNull);
                }
                name = value;
            }
        }

        public int OxygenLevel
        {
            get => oxygenLevel;
            protected set
            {
                oxygenLevel = Math.Max(value, 0);
            }
        }

        public IReadOnlyCollection<string> Catch => caughtFish.AsReadOnly();

        public double CompetitionPoints => Math.Round(competitionPoints, 1);

        public bool HasHealthIssues => isHealthIssues;

        public void Hit(IFish fish)
        {
            OxygenLevel -= fish.TimeToCatch;
            if (OxygenLevel < 0)
            {
                OxygenLevel = 0;
            }
            caughtFish.Add(fish.Name);
            competitionPoints += Math.Round(fish.Points, 1, MidpointRounding.AwayFromZero);
        }

        public abstract void Miss(int TimeToCatch);
        

        public abstract void RenewOxy();

        public void UpdateHealthStatus()
        {
            isHealthIssues = !isHealthIssues;
        }

        public override string ToString()
        {
            return $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {caughtFish.Count}, Points earned: {CompetitionPoints} ]";
        }
    }
}
