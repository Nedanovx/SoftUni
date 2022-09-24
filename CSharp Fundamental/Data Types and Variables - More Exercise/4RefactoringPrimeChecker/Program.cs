using System;

namespace _4RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < i; divisor++)
                {
                    if (i % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.Write($"{i} -> ");
                Console.WriteLine(isPrime.ToString().ToLower());
            }


        }
    }
}
