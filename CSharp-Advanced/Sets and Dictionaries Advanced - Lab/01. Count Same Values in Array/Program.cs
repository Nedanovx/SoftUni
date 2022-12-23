using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            for(int i = 0; i < input.Length; i++)
            {
                if (!numbers.ContainsKey(input[i]))
                {
                    numbers.Add(input[i], 1);
                }
                else
                {
                    numbers[input[i]]++;
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
