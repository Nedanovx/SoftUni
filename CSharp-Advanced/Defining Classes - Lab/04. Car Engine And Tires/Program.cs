using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[]
            {
                new Tire  (2020, 2.2),
                new Tire  (2020, 2.2),
                new Tire  (2020, 2.2),
                new Tire  (2020, 2.2),

            };

            Engine engine = new Engine(90, 1.4);
            Car car = new Car("Lada", "2105", 1992, 45, 10,engine, tires);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
