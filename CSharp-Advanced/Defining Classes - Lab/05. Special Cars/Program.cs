using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            string input = Console.ReadLine();
            while(input != "No more tires")
            {
                string[] tiresInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] currentTires = new Tire[4]
                {
                    new Tire(int.Parse(tiresInfo[0]), double.Parse(tiresInfo[1])),
                    new Tire(int.Parse(tiresInfo[2]), double.Parse(tiresInfo[3])),
                    new Tire(int.Parse(tiresInfo[4]), double.Parse(tiresInfo[5])),
                    new Tire(int.Parse(tiresInfo[6]), double.Parse(tiresInfo[7])),
                };
                tires.Add(currentTires);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            
            while(input != "Engines done")
            {
                string[] engineInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);
               
                Engine engine = new Engine(horsePower, cubicCapacity);
                
                engines.Add(engine);
                
                input = Console.ReadLine();
            }
            
            input = Console.ReadLine();
            
            while(input != "Show special")
            {
                string[] carInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Car car = new Car(make,model,year,fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);

                cars.Add(car);

                input = Console.ReadLine();
            }
            Console.WriteLine(GetSpecialCar(cars));
        }
        public static string GetSpecialCar(List<Car>cars)
        {
            List<Car> specialCar = cars.Where(x => x.Year >= 2017)
                .Where(x => x.Engine.HorsePower > 330)
                .Where(x => x.Tires.Sum(c => c.Pressure) >= 9 && x.Tires.Sum(c => c.Pressure) <= 10)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach(var car in specialCar)
            {
                car.Drive(20);
                sb.AppendLine($"Make: {car.Make}");
                sb.AppendLine($"Model: {car.Model}");
                sb.AppendLine($"Year: {car.Year}");
                sb.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                sb.AppendLine($"FuelQuantity: {car.FuelQuantity}");
            }
            return sb.ToString();
        }
    }
}
