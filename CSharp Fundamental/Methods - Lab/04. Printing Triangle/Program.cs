using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                ColomnsLoop(row);
                Console.WriteLine();
            }
            for (int row = input-1; row >= 1; row--)
            {
                ColomnsLoop(row);
                Console.WriteLine();
            }
        }

        private static void ColomnsLoop(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
        }
    }
}
