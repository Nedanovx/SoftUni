using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        private const double HenWeightIncrease = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightIncrease => HenWeightIncrease;

        public override IReadOnlyCollection<Type> PreferredFoods
            => new HashSet<Type>{typeof(Meat), typeof(Vegetable), typeof(Fruit), typeof(Seeds)};

        public override string ProduceSound()
        {
        return "Cluck";
        }
    }
}
