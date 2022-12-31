using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, SortedSet<string>> side = new Dictionary<string, SortedSet<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] split = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = split[0];
                    string forceUser = split[1];
                    if (!side.Values.Any(x => x.Contains(forceUser)))
                    {
                        if (!side.ContainsKey(forceSide))
                        {
                            side.Add(forceSide, new SortedSet<string>());
                        }
                        side[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    string[] split = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = split[0];
                    string forceSide = split[1];

                    foreach (var kvp in side)
                    {
                        if (kvp.Value.Contains(forceUser))
                        {
                            kvp.Value.Remove(forceUser);
                            break;
                        }
                    }
                    if (!side.ContainsKey(forceSide))
                    {
                        side.Add(forceSide, new SortedSet<string>());
                    }
                    side[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                input = Console.ReadLine();
            }

            foreach (var name in side.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (name.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {name.Key}, Members: {name.Value.Count}");
                    foreach (var pair in name.Value)
                    {
                        Console.WriteLine($"! {pair}");
                    }
                }
            }

        }
    }
}
