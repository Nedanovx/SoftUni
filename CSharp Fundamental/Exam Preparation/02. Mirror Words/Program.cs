using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@|#])(?<word1>[A-Za-z]{3,})(\1){2}(?<word2>[A-Za-z]{3,})(\1)";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            List<string> result = new List<string>();
            if (matchCollection.Count > 0)
            {
                Console.WriteLine($"{matchCollection.Count} word pairs found!");
                
                foreach (Match match in matchCollection)
                {
                    string word1 = match.Groups["word1"].Value;
                    string word2 = match.Groups["word2"].Value;
                    StringBuilder sb = new StringBuilder();
                    for (int i = word2.Length - 1; i >= 0; i--)
                    {
                        sb.Append(word2[i]);
                    }

                    if (word1 == sb.ToString())
                    {
                        result.Add($"{word1} <=> {word2}");                                           
                    }

                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            if(result.Count > 0)
            {
                Console.WriteLine($"The mirror words are:");
                Console.Write(String.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
            
           
        }
    }
}
