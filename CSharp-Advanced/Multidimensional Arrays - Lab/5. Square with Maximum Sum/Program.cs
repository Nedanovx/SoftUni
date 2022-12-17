using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            for(int row = 0; row < matrixSize[0]; row++)
            {
                int[] rowInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = rowInfo[col];
                }
            }
            int maxSum = 0;
            int subRow = 0;
            int subCol = 0;
            for(int row = 0; row < matrixSize[0] -1; row++)
            {
                for(int col = 0; col < matrixSize[1] -1; col++)
                {
                    int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row+1,col+1];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        subCol = col;
                        subRow = row;
                    }
                }
            }
            Console.WriteLine($"{matrix[subRow, subCol]} {matrix[subRow, subCol + 1]}");
            Console.WriteLine($"{matrix[subRow+1,subCol]} {matrix[subRow + 1, subCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
