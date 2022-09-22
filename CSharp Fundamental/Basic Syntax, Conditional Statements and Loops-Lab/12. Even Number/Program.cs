using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isNumIsodd = true;
            while (isNumIsodd)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");

                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }
            }
        }
    }
}