using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            double sum = 0;
            string pattern = @"^>>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quantity>\d+)(\.\d+){0,1}$";
            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string furnitureName = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quatity = double.Parse(match.Groups["quantity"].Value);
                    furniture.Add(furnitureName);
                    sum += price * quatity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach(string furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
