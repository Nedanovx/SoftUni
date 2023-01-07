using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action <string[]> printName = name => Console.WriteLine(string.Join(Environment.NewLine, name));
            printName(names);
        }
    }
}
