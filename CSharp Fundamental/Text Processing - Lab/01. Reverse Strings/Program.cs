using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, StringBuilder> words = new Dictionary<string, StringBuilder>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (!words.ContainsKey(command))
                {
                    StringBuilder reverseWord = new StringBuilder();
                    for(int i = command.Length-1; i >= 0; i--)
                    {
                        reverseWord.Append(command[i]);
                    }
                    words.Add(command, reverseWord);
                }
                command = Console.ReadLine();
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} = {word.Value}");
            }
        }
    }
}
