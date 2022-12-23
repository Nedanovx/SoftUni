using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();
            while(command != "END")
            {
                string[] cmdArg = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                string plateNumber = cmdArg[1];
                if(cmdType == "IN")
                {
                    cars.Add(plateNumber);
                }
                else if(cmdType == "OUT" && cars.Contains(plateNumber))
                {
                    cars.Remove(plateNumber);
                }
                command = Console.ReadLine();
            }
            if(cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }           
        }
    }
}
