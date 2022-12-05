using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\w+|\W+)\>(?<digit>\d{3})\|(?<lowerCase>[a-z]{3})\|(?<upperCase>[A-Z]{3})\|(?<symbols>[\W|\w]{3})\<(\1)";
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(text);
                if(match.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    string digits = match.Groups["digit"].Value;
                    sb.Append(digits);
                    string lowerCase = match.Groups["lowerCase"].Value;
                    sb.Append(lowerCase);
                    string upperCase = match.Groups["upperCase"].Value;
                    sb.Append(upperCase);
                    string symbol = match.Groups["symbols"].Value;
                    sb.Append(symbol);
                    Console.WriteLine($"Password: {sb}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
