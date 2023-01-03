using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseFunc =n=>int.Parse(n);
               int[] number = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(parseFunc)
                .ToArray();
            Console.WriteLine(number.Length);
            Console.WriteLine(number.Sum());
        }
    }
}
