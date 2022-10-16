using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] commandParams = input.Split();
                string command = commandParams[0];
                if (command == "Add")
                {
                    int passanger = int.Parse(commandParams[1]);
                    wagon.Add(passanger);
                }
                else
                {
                    for(int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] + int.Parse(input) <= maxCapacity)
                        {
                            wagon[i] = wagon[i] + int.Parse(input);
                            break;
                        }                       
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagon));
        }
    }
}
