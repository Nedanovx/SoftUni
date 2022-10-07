using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOdd = 0;
            int sumEven = 0;
            int multipleOfOddsAndEven = 0;
            while (number > 0)
            {

                int currentNumber = 0;
                if (number % 10 != 0)
                {
                    currentNumber = number % 10;
                    CheckDigit(ref sumOdd, ref sumEven, currentNumber);
                }
                number /= 10;
            }
            multipleOfOddsAndEven = MultipleOfOddsAndEven(sumOdd, sumEven);
            Console.WriteLine(multipleOfOddsAndEven);
        }

        private static void CheckDigit(ref int sumOdd, ref int sumEven, int currentNumber)
        {
            if (currentNumber % 2 == 0)
            {
                sumOdd += currentNumber;
            }
            else
            {
                sumEven += currentNumber;
            }
        }

        private static int MultipleOfOddsAndEven(int sumOdd, int sumEven)
        {
            return sumEven * sumOdd;
        }
    }
}
