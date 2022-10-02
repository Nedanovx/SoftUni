using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int middleStartIndex = inputNumbers.Length / 4;
            int middleEndIndex = middleStartIndex + inputNumbers.Length / 2;

            int sumOfIndex = middleStartIndex - 1;

            for (int i = middleStartIndex; i < middleEndIndex; i++)
            {
                int sum = inputNumbers[i] + inputNumbers[sumOfIndex];
                Console.Write($"{sum} ");
                sumOfIndex--;
                if (sumOfIndex < 0)
                {
                    sumOfIndex = inputNumbers.Length - 1;
                }
            }

        }
    }
}
