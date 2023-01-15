using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int speed = int.Parse(carInfo[1]);
                int power = int.Parse(carInfo[2]);
                int weight = int.Parse(carInfo[3]);
                string type = carInfo[4];
                double frontLeftPressure = double.Parse(carInfo[5]);
                int frontLeftAge = int.Parse(carInfo[6]);
                double frontRightPressure = double.Parse(carInfo[7]);
                int frontRightAge = int.Parse(carInfo[8]);
                double rearLeftPressure = double.Parse(carInfo[9]);
                int rearLeftAge = int.Parse(carInfo[10]);
                double rearRightPressure = double.Parse(carInfo[11]);
                int rearRightAge = int.Parse(carInfo[12]);
                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);
                Tires[] tires = new Tires[4]
                {
                new Tires(frontLeftPressure, frontLeftAge),
                new Tires(frontRightPressure, frontRightAge),
                new Tires(rearLeftPressure, rearLeftAge),
                new Tires(rearRightAge, rearRightAge),
                };
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if(command == "fragile")
            {
                var currentCar = cars.Where(x => x.Cargo.Type == "fragile").Where(x => x.Tires.Any(y => y.Pressure < 1)).ToList();
                foreach(var car in currentCar)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                var currentCar = cars.Where(x => x.Cargo.Type == "flammable").Where(x => x.Engine.Power > 250).ToList();
                foreach (var car in currentCar)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}

//{ model} { engineSpeed} { enginePower} { cargoWeight} { cargoType} { tire1Pressure} { tire1Age}
//{ tire2Pressure} { tire2Age} { tire3Pressure} { tire3Age} { tire4Pressure} { tire4Age}