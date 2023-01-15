using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numbersOfCars = int.Parse(Console.ReadLine());
            for(int i = 0; i < numbersOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carsInfo[0];
                double fuelAmount = double.Parse(carsInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carsInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);              
                int distance = int.Parse(cmdArg[2]);
                Car car = cars.Where(x => x.Model == cmdArg[1]).FirstOrDefault();
                car.Drive(distance);

                command = Console.ReadLine();
            }
            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Kilometer}");
            }
        }
    }
}
