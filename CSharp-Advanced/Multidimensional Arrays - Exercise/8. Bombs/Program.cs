using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, rows];
            for(int row = 0; row < rows; row++)
            {
                int[] rowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for(int col = 0; col < rows; col++)
                {
                    matrix[row,col] = rowInfo[col];
                }
            }
             string[] bombIndex = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < bombIndex.Length; i++)
            {
                int[] bomb = bombIndex[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int rowBomb = bomb[0];
                int colBomb = bomb[1];
                for(int row = 0; row < matrix.GetLength(0); row++)
                {
                    for(int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (row == rowBomb && col == colBomb )
                        {
                            if (matrix[rowBomb, colBomb] > 0)
                            {
                                BombExplosion(matrix, rowBomb, colBomb);
                            }
                        }
                    }
                }               

            }
            int sum = 0;
            int count = 0;
            foreach(int row in matrix)
            {
                if(row > 0)
                {
                    sum += row;
                    count++;
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] BombExplosion(int[,] matrix, int rowBomb, int colBomb)
        {           
                if (rowBomb - 1 >= 0 && colBomb - 1 >= 0 && matrix[rowBomb - 1, colBomb - 1] > 0)
                {
                    matrix[rowBomb - 1, colBomb - 1] -= matrix[rowBomb, colBomb];                   
                }
                if (rowBomb - 1 >= 0 && matrix[rowBomb - 1, colBomb] > 0)
                {
                    matrix[rowBomb - 1, colBomb] -= matrix[rowBomb, colBomb];                    
                }
                if (rowBomb - 1 >= 0 && colBomb + 1 < matrix.GetLength(1) && matrix[rowBomb - 1, colBomb + 1] > 0)
                {
                    matrix[rowBomb - 1, colBomb + 1] -= matrix[rowBomb, colBomb];                   
                }
                if (colBomb - 1 >= 0 && matrix[rowBomb, colBomb - 1] > 0)
                {
                    matrix[rowBomb, colBomb - 1] -= matrix[rowBomb, colBomb];                    
                }
                if (colBomb + 1 < matrix.GetLength(1) && matrix[rowBomb, colBomb + 1] > 0)
                {
                    matrix[rowBomb, colBomb + 1] -= matrix[rowBomb, colBomb];                  
                }
                if (rowBomb + 1 < matrix.GetLength(0) && colBomb - 1 >= 0 && matrix[rowBomb + 1, colBomb - 1] > 0)
                {
                    matrix[rowBomb + 1, colBomb - 1] -= matrix[rowBomb, colBomb];                   
                }
                if (rowBomb + 1 < matrix.GetLength(0) && matrix[rowBomb + 1, colBomb] > 0)
                {
                    matrix[rowBomb + 1, colBomb] -= matrix[rowBomb, colBomb];                 
                }
                if (rowBomb + 1 < matrix.GetLength(0) && colBomb + 1 < matrix.GetLength(1) && matrix[rowBomb + 1, colBomb + 1] > 0)
                {
                    matrix[rowBomb + 1, colBomb + 1] -= matrix[rowBomb, colBomb];                    
                }
            matrix[rowBomb, colBomb] = 0;
            return matrix;
        }

    }
}
