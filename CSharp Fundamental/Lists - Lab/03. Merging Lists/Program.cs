using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int n = Math.Min(input1.Count, input2.Count);
            for (int i = 0; i < n; i++)
            {
                result.Add(input1[i]);
                result.Add(input2[i]);
            }
            if (input1.Count > input2.Count)
            {
                for (int i = n; i < input1.Count; i++)
                {
                    result.Add(input1[i]);
                }
            }
            else
            {
                for (int i = n; i < input2.Count; i++)
                {
                    result.Add(input2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
