namespace NauticalCatchChallenge.Models
{
    public class ScubaDiver : Diver
    {
        private const int ScubaDiverOxygenLevel = 540;
        private const double OxygenDecrease = 0.3;
        public ScubaDiver(string name) : base(name, ScubaDiverOxygenLevel)
        {
        }

        public override void Miss(int TimeToCatch)
        {
            OxygenLevel -= (int)Math.Round(OxygenDecrease * TimeToCatch);
        }

        public override void RenewOxy()
        {
            base.OxygenLevel = ScubaDiverOxygenLevel;
        }
    }
}
