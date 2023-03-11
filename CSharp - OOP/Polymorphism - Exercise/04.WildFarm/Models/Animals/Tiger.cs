using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double TigerWeightIncrease = 1.0;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightIncrease => TigerWeightIncrease;

        public override IReadOnlyCollection<Type> PreferredFoods 
            => new HashSet<Type> {typeof(Meat)};

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
