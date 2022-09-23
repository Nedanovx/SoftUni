using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000.0;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}