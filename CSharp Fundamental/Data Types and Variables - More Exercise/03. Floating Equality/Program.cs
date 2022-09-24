using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = 0;
            if (num1 > num2)
            {
                difference = num1 - num2;
                if (difference > eps)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
            else if (num1 < num2)
            {
                difference = num2 - num1;
                if (difference > eps)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
