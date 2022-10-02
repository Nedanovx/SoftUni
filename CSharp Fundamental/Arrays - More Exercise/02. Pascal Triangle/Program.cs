using System;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 1;
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    
                }
                for (int k = 0; k <= i; k++)
                {
                    if (k == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - k + 1) / k;
                    Console.Write($"{val} ");
                }
                Console.WriteLine();
            }
        }
    }
}
