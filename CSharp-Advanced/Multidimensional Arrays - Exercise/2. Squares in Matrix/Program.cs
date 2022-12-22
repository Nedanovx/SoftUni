using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];          
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rowInfo = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for(int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if(matrix[i, j] == matrix[i,j+1] && matrix[i,j] == matrix[i+1,j] && matrix[i,j] == matrix[i+1,j+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
