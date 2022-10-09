using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double facturial = 1;
            double facturial2 = 1;
            double result = FactorialDivision(number1, number2, ref facturial, ref facturial2);
            Console.WriteLine($"{result:f2}");

        }

        private static double FactorialDivision(int number1, int number2, ref double facturial, ref double facturial2)
        {
            for (int i = 1; i <= number1; i++)
            {
                
                facturial *= i;
            }
            for (int i = 1; i <= number2; i++)
            {
                facturial2 *= i;
            }
            return  facturial / facturial2;
        }
    }
}
