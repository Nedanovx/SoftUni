using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Fish : IFish
    {
        private string name;
        private double points;
        private int timeToCatch;

        protected Fish(string name, double points, int timeToCatch) 
        { 
            Name = name;
            Points = points;
            TimeToCatch = timeToCatch;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.FishNameNull);
                }
                name = value;
            }
        }

        public double Points
        {
            get { return points; }
            private set
            {
                if (value < 1 || value > 10 || Math.Round(value, 1) != value)
                {
                    throw new ArgumentException(ExceptionMessages.PointsNotInRange);
                }
                points = value;
            }
        }

        public int TimeToCatch { get { return timeToCatch; } protected set { timeToCatch = value; } }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name} [ Points: {Points}, Time to Catch: {TimeToCatch} seconds ]";
        }
    }
}
