using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            
        }

        public string Name {get; private set;}

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        public abstract double WeightIncrease { get; }

        public abstract IReadOnlyCollection<Type> PreferredFoods { get; }
        public void Eat(IFood food)
        {
            if(!PreferredFoods.Any(x=>x.Name == food.GetType().Name))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            Weight += food.Quantity * WeightIncrease;
            FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();     

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
