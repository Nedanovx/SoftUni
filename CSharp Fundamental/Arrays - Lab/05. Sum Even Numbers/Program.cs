using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            for(int i = 0; i < number.Length; i++)
            {
                int currentNumber = number[i];
                if(currentNumber % 2== 0)
                {
                    sum += currentNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
