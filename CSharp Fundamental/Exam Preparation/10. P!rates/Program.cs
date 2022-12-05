using System;
using System.Collections.Generic;
using System.Drawing;

namespace _10._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plan = Console.ReadLine();
            Dictionary<string, int> townAndPopulation = new Dictionary<string, int>();
            Dictionary<string, int> townAndGold = new Dictionary<string, int>();
            while(plan != "Sail")
            {
                string[] planArg = plan.Split("||");
                string town = planArg[0];
                int population = int.Parse(planArg[1]);
                int gold = int.Parse(planArg[2]);
                if(!townAndPopulation.ContainsKey(town))
                {
                    townAndPopulation.Add(town, population);
                    townAndGold.Add(town, gold);
                }
                else
                {
                    townAndPopulation[town] += population;
                    townAndGold[town] += gold;
                }
                plan = Console.ReadLine();
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] cmdArg = command.Split("=>");
                string cmdType = cmdArg[0];
                if (cmdType == "Plunder")
                {
                    string town = cmdArg[1];
                    int population = int.Parse(cmdArg[2]);
                    int gold = int.Parse(cmdArg[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");
                    townAndGold[town] -= gold;
                    townAndPopulation[town] -= population;
                    if (townAndGold[town] <= 0 || townAndPopulation[town] <= 0)
                    {
                        townAndGold.Remove(town);
                        townAndPopulation.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }                 
                }
                else if(cmdType == "Prosper")
                {
                    string town = cmdArg[1];
                    int gold = int.Parse(cmdArg[2]);
                    if(gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        townAndGold[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {townAndGold[town]} gold.");
                    }
                }

                command = Console.ReadLine();
            }
            if(townAndPopulation.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {townAndPopulation.Count} wealthy settlements to go to:");
                foreach(var city in townAndPopulation.Keys)
                {
                    Console.WriteLine($"{city} -> Population: {townAndPopulation[city]} citizens, Gold: {townAndGold[city]} kg");
                }
            }
        }
    }
}
