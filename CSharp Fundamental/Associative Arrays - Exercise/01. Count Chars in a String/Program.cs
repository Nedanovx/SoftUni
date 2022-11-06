using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            List<char> text = Console.ReadLine().Where(x => x !=' ').ToList();
            
            foreach(char symbol in text)
            {
                if(!chars.ContainsKey(symbol))
                {
                    chars.Add(symbol, 0);
                }
                chars[symbol] += 1;
            }
            foreach(var symbol in chars)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
