using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            MinNumber(number1, number2, number3);
        }

        static void MinNumber(int number1, int number2, int number3)
        {
            int min = 0;

            if (number1 >= number2)
            {
                if (number2 <= number3)
                {
                    min = number2;
                }
                else if (number3 < number2)
                {
                    min = number3;
                }

            }
            else if (number1 < number2)
            {
                if (number1 <= number3)
                {
                    min = number1;
                }
                else
                {
                    min = number3;
                }
            }
            Console.WriteLine(min);

        }
    }
}
