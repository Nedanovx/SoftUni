using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int numberOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine
                {
                    Model = engineInfo[0],
                    Power = int.Parse(engineInfo[1]),

                };

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out var displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    engine.Displacement = int.Parse(engineInfo[2]);
                    engine.Efficiency = engineInfo[3];
                }
                engines.Add(engine);
            }
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine findEngine = engines.FirstOrDefault(x => x.Model == carsInfo[1]);
                Car car = new Car
                {
                    Model = carsInfo[0],
                    Engine = findEngine,
                };
                if (carsInfo.Length == 3)
                {
                    if (int.TryParse(carsInfo[2], out var weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = carsInfo[2];
                    }
                }
                else if (carsInfo.Length == 4)
                {
                    car.Weight = int.Parse(carsInfo[2]);
                    car.Color = carsInfo[3];
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement.HasValue)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                if (car.Engine.Efficiency != null)
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                if (car.Weight.HasValue)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if (car.Color != null)
                { 
                Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"  Color: n/a");
                }
            }
        }
    }
}
