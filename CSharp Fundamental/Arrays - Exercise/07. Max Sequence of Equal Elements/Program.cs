using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int count = 1;
            int longestCount = 1;
            int number = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                }
                if (count > longestCount)
                {
                    longestCount = count;
                    number = numbers[i];
                }
                if (numbers[i] != numbers[i-1])
                {
                    count=1;
                }
            }
            for (int i = 0; i < longestCount; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
