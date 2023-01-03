using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startWithCapital = w => Char.IsUpper(w[0]);
            string[] input = Array.FindAll(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                , startWithCapital);
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
