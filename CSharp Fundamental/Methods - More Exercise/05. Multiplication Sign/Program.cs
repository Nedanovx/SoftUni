using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }

            count = IsNumNegative(count, num1, num2, num3);

            if (count == 0 || count == 2)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }

        }

        private static int IsNumNegative(int count, int num1, int num2, int num3)
        {
            if (num1 < 0)
            {
                count++;
            }
            else if (num2 < 0)
            {
                count++;
            }
            else if (num3 < 0)
            {
                count++;
            }
            return count;
        }
    }
}
