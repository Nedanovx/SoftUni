using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixInfo[0];
            int cols = matrixInfo[1];
            int[,] matrix = new int[rows, cols];
            for(int row = 0; row < rows; row++)
            {
                int[] rowInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowInfo[col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            int sum = 0;
            foreach(int item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
