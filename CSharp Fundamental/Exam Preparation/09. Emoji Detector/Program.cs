using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _09._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})(\1)";
            BigInteger coolThreshold = 1;
            string input = Console.ReadLine();          
            foreach(char symbol in input)
            {
                if(char.IsDigit(symbol))
                {
                    int digit = (int)symbol - 48;
                    coolThreshold *= digit;
                }
            }
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matchCollection.Count} emojis found in the text. The cool ones are:");          
            foreach(Match match in matchCollection)
            {
                string emoji = match.Groups["emoji"].Value;
                BigInteger emojiCoolness = 0;
                foreach(char symbol in emoji)
                {
                    emojiCoolness += (int)symbol;
                }
                if(emojiCoolness >= coolThreshold)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }
            

        }
    }
}
