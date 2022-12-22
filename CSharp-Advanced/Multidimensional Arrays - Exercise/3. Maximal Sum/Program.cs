using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            for(int i = 0; i < matrixSize[0]; i++)
            {
                int[] rowInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for(int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }
            int maxSum = int.MinValue;
            int rowIndex = 0;
            int colindex = 0;
            for(int i = 0; i < matrix.GetLength(0)-2; i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                   int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] 
                        + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = i;
                        colindex = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = rowIndex; i < rowIndex+3; i++)
            {             
                for (int j = colindex; j < colindex+3; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
