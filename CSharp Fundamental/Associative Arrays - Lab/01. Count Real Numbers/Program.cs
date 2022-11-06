using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var number in inputNumbers)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);

                }
                numbers[number] += 1;
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
