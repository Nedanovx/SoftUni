using System;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach(string word in words)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }              
            }
            Console.Write(result);
        }
    }
}
