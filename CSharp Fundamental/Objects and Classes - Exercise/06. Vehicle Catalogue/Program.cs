using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();
            double totalCarHP = 0;
            double totalTruckHP = 0;
            int countCar = 0;
            int countTruck = 0;

            while (command != "End")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArg[0];
                if (type == "car")
                {
                    string model = cmdArg[1];
                    string color = cmdArg[2];
                    int horsePower = int.Parse(cmdArg[3]);
                    Vehicle car = new Vehicle("Car", model, color, horsePower);
                    vehicles.Add(car);
                    totalCarHP+=horsePower;
                    countCar++;
                }
                else if (type == "truck")
                {
                    string model = cmdArg[1];
                    string color = cmdArg[2];
                    int horsePower = int.Parse(cmdArg[3]);
                    Vehicle truck = new Vehicle("Truck", model, color, horsePower);
                    vehicles.Add(truck);
                    totalTruckHP+= horsePower;
                    countTruck++;
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while(command != "Close the Catalogue")
            {
                foreach(Vehicle vehicle in vehicles.Where(x=>x.Model == command))
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
                command= Console.ReadLine();
            }
            if (countCar > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {totalCarHP / (double)countCar:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (countTruck > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {totalTruckHP / (double)countTruck:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}
