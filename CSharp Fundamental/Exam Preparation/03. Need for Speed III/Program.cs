using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, int> carsAndMiles = new Dictionary<string, int>();
            Dictionary<string, int> carAndFuel = new Dictionary<string, int>();
            for(int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
                string car = carInfo[0];
                int miles = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);
                if(!carsAndMiles.ContainsKey(car))
                {
                    carsAndMiles[car] = miles;
                    carAndFuel[car] = fuel;
                }
            }
            string command = Console.ReadLine();
            while(command != "Stop")
            {
                string[] cmdArg = command.Split(" : ",StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                
                if(cmdType == "Drive")
                {
                    string car = cmdArg[1];
                    int miles = int.Parse(cmdArg[2]);
                    int fuel = int.Parse(cmdArg[3]);
                    int timeToSell = 100000;
                    if (fuel > carAndFuel[car])
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    else
                    {
                        carAndFuel[car] -= fuel;
                        carsAndMiles[car] += miles;
                        Console.WriteLine($"{car} driven for {miles} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if(timeToSell <= carsAndMiles[car])
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        carAndFuel.Remove(car);
                        carsAndMiles.Remove(car);
                    }
                }
                else if(cmdType == "Refuel")
                {
                    int fuelTank = 75;
                    string car = cmdArg[1];
                    int fuel = int.Parse(cmdArg[2]);
                    int neededFuel = fuelTank - carAndFuel[car];
                    carAndFuel[car] += fuel;
                    if (carAndFuel[car] > fuelTank)
                    {
                        Console.WriteLine($"{car} refueled with {neededFuel} liters");
                        carAndFuel[car] = fuelTank;
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if(cmdType == "Revert")
                {
                    string car = cmdArg[1];
                    int miles = int.Parse(cmdArg[2]);
                    carsAndMiles[car] -= miles;
                    if (carsAndMiles[car] > 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {miles} kilometers");
                    }
                    else
                    {
                        carsAndMiles[car] = 10000;
                    }
                }
                command = Console.ReadLine();
            }
            foreach(var car in carsAndMiles)
            {                              
                    Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carAndFuel[car.Key]} lt.");               
            }
        }
    }
}
