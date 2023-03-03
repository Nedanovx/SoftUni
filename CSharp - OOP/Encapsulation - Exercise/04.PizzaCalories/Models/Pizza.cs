namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();    
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if(value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public Dough Dough { get; private set; }
        public double Calories
        {
            get
            {
                return Dough.Calories + toppings.Sum(x => x.Calories);
            }
        }
        public void AddTopping(Topping topping)
        {
            if(toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        public override string ToString()
        {
            return $"{Name} - {Calories:f2} Calories.";
        }
    }
}
