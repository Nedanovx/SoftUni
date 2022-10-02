using System;
using System.Transactions;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]fibonacci = new int[n];
            fibonacci[0] = 1;
            if (fibonacci.Length <= 1)
            {
                Console.WriteLine(1);
                return; 
            }
            else
            {
                fibonacci[1] = 1;
                for (int i = 2; i < fibonacci.Length; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            Console.WriteLine(fibonacci[n-1]);
            
        }
    }
}
