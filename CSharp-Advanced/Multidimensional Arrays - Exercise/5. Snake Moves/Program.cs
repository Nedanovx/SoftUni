using System;
using System.Data;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            string snake = Console.ReadLine();
            int snakeIndex = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        snakeIndex = NewMethod(matrix, snake, snakeIndex, i, j);
                    }
                }
                else
                {
                    for(int j = matrix.GetLength(1)-1; j >= 0; j--)
                    {
                        snakeIndex = NewMethod(matrix, snake, snakeIndex, i, j);
                    }
                }
            }
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j =0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static int NewMethod(char[,] matrix, string snake, int snakeIndex, int i, int j)
        {
            if (snakeIndex == snake.Length)
            {
                snakeIndex = 0;
            }
            matrix[i, j] = snake[snakeIndex];
            snakeIndex++;
            return snakeIndex;
        }
    }
}
