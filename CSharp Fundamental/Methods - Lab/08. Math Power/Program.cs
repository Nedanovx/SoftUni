using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            double result = MathPower(baseNumber, powerNumber);
            Console.WriteLine($"{result}");
        }

        private static double MathPower(double baseNumber, int powerNumber)
        {
            double result = baseNumber;
            for (int i = 1; i < powerNumber; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
