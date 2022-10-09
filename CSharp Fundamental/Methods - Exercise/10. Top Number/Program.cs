using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNUmber(number);
        }

        private static void TopNUmber(int number)
        {
            for (int i = 0; i < number; i++)
            {
                int sum = 0;

                int currentNumber = i;
                int secondNumber = currentNumber;

                int count = 0;

                while (secondNumber > 0)
                {
                    currentNumber = secondNumber % 10;
                    secondNumber = secondNumber / 10;

                    if (currentNumber % 2 != 0)
                    {
                        count++;
                    }

                    sum += currentNumber;
                }

                if (sum % 8 == 0 && count > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
