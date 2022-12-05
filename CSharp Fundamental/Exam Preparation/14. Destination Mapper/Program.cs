using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _14._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\=|\/])[A-Z][A-Za-z]{2,}(\1)";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            int sum = 0;
            List<string> strings = new List<string>();
            MatchCollection match = regex.Matches(input);
            {
                foreach (Match word in match)
                {
                    string[] destinationArray = word.Value.Split(new char[] {'=', '/'});
                    string destination = destinationArray[1];
                    sum += destination.Length;
                    strings.Add(destination);
                }
            }
            Console.WriteLine($"Destinations: {string.Join(", ", strings)}");           
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
