using Restaurant;

namespace _05.Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50M;

        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        public double Caffeine { get; private set; }
    }
}
