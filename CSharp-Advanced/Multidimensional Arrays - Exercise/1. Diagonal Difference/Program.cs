using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows,rows];
            for(int row = 0; row < rows; row++)
            {
                int[] rowInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < rows; col++)
                {
                    matrix[row,col] = rowInfo[col];
                }
            }
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int row = 0; row < rows; row++)
            {
                primaryDiagonal += matrix[row,row];
                secondaryDiagonal += matrix[row, rows - 1 - row];
            }                    
            int result = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(result);
        }
    }
}
