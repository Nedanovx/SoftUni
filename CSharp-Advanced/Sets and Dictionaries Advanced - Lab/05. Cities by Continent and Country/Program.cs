using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> map = new Dictionary<string, Dictionary<string, List<string>>>();
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continents = input[0];
                string countries = input[1];
                string cities = input[2];
                if (!map.ContainsKey(continents))
                {
                    map.Add(continents, new Dictionary<string, List<string>>());
                    if (!map[continents].ContainsKey(countries))
                    {
                        map[continents].Add(countries, new List<string>());
                        map[continents][countries].Add(cities);
                    }
                   
                }
                else if(map.ContainsKey(continents) && !map[continents].ContainsKey(countries))
                {
                    map[continents].Add(countries, new List<string>());
                    map[continents][countries].Add(cities);
                }
                else if (map.ContainsKey(continents) && map[continents].ContainsKey(countries))
                {
                    map[continents][countries].Add(cities);
                }
            }
            foreach(var continent in map)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach(var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
