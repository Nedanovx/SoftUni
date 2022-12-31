using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vlogers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] inputArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = inputArg[1];
                if (cmdType == "joined")
                {
                    string vloger = inputArg[0];
                    if (!vlogers.ContainsKey(vloger))
                    {
                        vlogers.Add(vloger, new Dictionary<string, HashSet<string>>());
                        vlogers[vloger].Add("followers", new HashSet<string>());
                        vlogers[vloger].Add("following", new HashSet<string>());
                    }
                }
                else if (cmdType == "followed")
                {
                    string firstVloger = inputArg[0];
                    string secondVloger = inputArg[2];
                    if (firstVloger != secondVloger && vlogers.ContainsKey(firstVloger) && vlogers.ContainsKey(secondVloger))
                    {
                        vlogers[firstVloger]["following"].Add(secondVloger);
                        vlogers[secondVloger]["followers"].Add(firstVloger);
                    }
                }
                input = Console.ReadLine();
            }
            int count = 1;
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            foreach (var kvp in vlogers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value["followers"].Count} followers, {kvp.Value["following"].Count} following");

                if(count == 1)
                {
                    foreach(var follower in kvp.Value["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
}
