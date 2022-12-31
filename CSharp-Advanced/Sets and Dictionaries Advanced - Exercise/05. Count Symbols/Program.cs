using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            for(int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if(!symbols.ContainsKey(c))
                {
                    symbols.Add(c, 0);
                }
                symbols[c]++;
            }
            foreach(var kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
