using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factoriel = 1;
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
