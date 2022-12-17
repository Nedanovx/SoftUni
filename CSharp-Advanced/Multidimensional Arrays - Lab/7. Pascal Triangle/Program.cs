using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] pascal =new long[rows][];
            for(int row = 0; row < rows; row++)
            {
                pascal[row] = new long[rows + 1];
                for(int col = 0; col < row+1; col++)
                {
                    if(col > 0 && col < pascal[row].Length-1)
                    {
                        pascal[row][col] = pascal[row - 1][col-1] + pascal[row - 1][col];
                    }
                    else
                    {
                        pascal[row][col] = 1;
                    }
                }
            }
            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < row+1; col++)
                {
                    Console.Write($"{pascal[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
