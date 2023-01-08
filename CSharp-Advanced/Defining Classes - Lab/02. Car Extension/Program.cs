using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           Car car = new Car(); 
            car.Make = "Volvo";
            car.Model = "S60";
            car.Year = 2005;
            car.FuelQuantity = 50;
            car.FuelConsumption = 7.5;
            car.Drive(6);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
