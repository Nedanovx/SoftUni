using System;

namespace CarManufacturer
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Opel";
            car.Model = "Astra";
            car.Year = 1999;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
