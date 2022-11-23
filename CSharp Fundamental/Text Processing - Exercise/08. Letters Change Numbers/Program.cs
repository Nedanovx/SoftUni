using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (string item in input)
            {
                char firstSymbol = item[0];
                char secondSymbol = item[item.Length - 1];
                string numberString = item[1..^1];
                double number = double.Parse(numberString);
                if (Char.IsUpper(firstSymbol))
                {
                    int positionOfTheLetter = firstSymbol - 64;
                    number /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstSymbol - 96;
                    number *= positionOfTheLetter;
                }

                if (Char.IsUpper(secondSymbol))
                {
                    int positionOfTheLetter = secondSymbol - 64;
                    number -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = secondSymbol - 96;
                    number += positionOfTheLetter;
                }
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
