using System;
namespace _02._From_Left_to_The_Right
{
    internal class FromLeftToTheRight
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string input = Console.ReadLine();
                string[] split = input.Split(' ');
                long firstNumber = long.Parse(split[0]);
                long secondNumber = long.Parse(split[1]);
                long sum = 0;
                if (firstNumber > secondNumber)
                {
                    while (firstNumber != 0)
                    {
                        sum += firstNumber % 10;
                        firstNumber /= 10;
                    }
                }
                else
                {
                    while (secondNumber != 0)
                    {
                        sum += secondNumber % 10;
                        secondNumber /= 10;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
