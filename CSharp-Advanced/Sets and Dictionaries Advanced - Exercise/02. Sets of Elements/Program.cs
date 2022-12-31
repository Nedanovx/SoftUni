using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for(int i = 0; i < number[0]; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for(int i = 0; i < number[1]; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }
            first.IntersectWith(second);
            Console.WriteLine(String.Join(" ", first));
        }
    }
}
