namespace PizzaCalories.Models
{
    public class Topping
    {
        private const double BaseToppingCaloriesPerGram = 2;
        private readonly Dictionary<string, double> typesOfTopping;
        private string type;
        private double weight;
        //Meat - 1.2;         Veggies - 0.8;       Cheese - 1.1;        Sauce - 0.9
        public Topping(string type, double weight)
        {
            typesOfTopping = new Dictionary<string, double> { { "meat", 1.2 }, { "veggies", 0.8 }, { "cheese", 1.1 }, { "sauce", 0.9 } };
            Type = type;
            Weight = weight;
        }
        public string Type
        {
            get { return type; }
            private set
            {
                if(!typesOfTopping.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }
        public double Weight
        {
            get { return weight; }
            private set
            {
                if(value < 0 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public double Calories
        {
            get
            {
                double typeModifier = typesOfTopping[Type.ToLower()];

                return BaseToppingCaloriesPerGram * Weight * typeModifier;
            }
        }
    }
}
