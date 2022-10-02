using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                int nextElementPosition = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        leftSum += numbers[nextElementPosition];
                    }
                }
                rightSum = 0;
                for(int sumRight = i; sumRight < numbers.Length; sumRight++)
                {
                    int nextElementPosition = sumRight + 1;
                    if (sumRight < numbers.Length-1)
                    {
                        rightSum += numbers[nextElementPosition];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
