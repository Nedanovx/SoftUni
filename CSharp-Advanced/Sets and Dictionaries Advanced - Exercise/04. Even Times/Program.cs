using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for(int i = 0; i < input; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }               
                    numbers[number]++;               
            }
            Console.WriteLine(numbers.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
