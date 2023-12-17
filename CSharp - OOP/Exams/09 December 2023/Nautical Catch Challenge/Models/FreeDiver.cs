using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public class FreeDiver : Diver
    {
        private const int FreeDiverOxygenLevel = 120;
        private const double OxygenDecrease = 0.6;
        public FreeDiver(string name) : base(name, FreeDiverOxygenLevel)
        {
        }

        public override void Miss(int TimeToCatch)
        {
            OxygenLevel -= (int)Math.Round(OxygenDecrease * TimeToCatch);
        }

        public override void RenewOxy()
        {
            base.OxygenLevel = FreeDiverOxygenLevel;
        }
    }
}
