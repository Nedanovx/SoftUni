using System;
using System.Text.RegularExpressions;

namespace _11._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\#|\|])(?<item>[A-Za-z]+\s*[A-Za-z]+)(\1)(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})(\1)(?<cal>\d{1,5})(\1)";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int totalCal = 0;
            foreach(Match match in matches)
            {             
                int calories = int.Parse(match.Groups["cal"].Value);
                totalCal+= calories;
            }
            if (totalCal > 0)
            {
                int day = totalCal / 2000;
                if (day > 0)
                {
                    Console.WriteLine($"You have food to last you for: {day} days!");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"Item: {match.Groups["item"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["cal"]}");
                    }
                }
                else
                {
                    Console.WriteLine("You have food to last you for: 0 days!");
                }
            }
            else
            {
                Console.WriteLine("You have food to last you for: 0 days!");
            }
        }
    }
}
