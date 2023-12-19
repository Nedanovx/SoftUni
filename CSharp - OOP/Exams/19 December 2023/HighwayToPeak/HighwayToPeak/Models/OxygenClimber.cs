using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public class OxygenClimber : Climber
    {
        private const int OxygenClimberStamina = 10;
        public OxygenClimber(string name) : base(name, OxygenClimberStamina)
        {
        }

        public override void Rest(int daysCount)
        {
            base.Stamina += daysCount;
        }
    }
}
