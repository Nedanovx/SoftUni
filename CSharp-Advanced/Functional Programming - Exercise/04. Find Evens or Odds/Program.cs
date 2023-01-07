using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = x => x % 2 == 0;
            Predicate<int> odd = x => x % 2 != 0;
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            for(int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }
            string command = Console.ReadLine();
            if(command == "even")
            {
                List<int>result = numbers.FindAll(even);
                Console.WriteLine(String.Join(" ",result));
            }
            else
            {
                List<int> result = numbers.FindAll(odd);
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
