using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            int startRow = 0;
            int startCol = 0;
            int feed = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                string rowInfo = Console.ReadLine();
                for (int j = 0; j < rowInfo.Length; j++)
                {
                    if (rowInfo[j] == 'S')
                    {
                        startRow = i;
                        startCol = j;
                    }
                    matrix[i, j] = rowInfo[j];
                }
            }

            while (feed < 10)
            {

                string command = Console.ReadLine();
                switch (command)
                {
                    case "left":
                        if (startCol - 1 >= 0)
                        {
                            Left(matrix, ref startRow, ref startCol, ref feed);
                        }
                        else
                        {
                            PrintMatrix(matrix, startRow, startCol, feed);
                            return;
                        }
                        break;
                    case "right":
                        if (startCol + 1 < matrixSize)
                        {
                            Right(matrix, ref startRow, ref startCol, ref feed);
                        }
                        else
                        {
                            PrintMatrix(matrix, startRow, startCol, feed);
                            return;
                        }
                        break;
                    case "down":
                        if (startRow + 1 < matrixSize)
                        {
                            Down(matrix, ref startRow, ref startCol, ref feed);
                        }
                        else
                        {
                            PrintMatrix(matrix, startRow, startCol, feed);
                            return;
                        }
                        break;
                    case "up":
                        if (startRow - 1 >= 0)
                        {
                            Up(matrix, ref startRow, ref startCol, ref feed);
                        }
                        else
                        {
                            PrintMatrix(matrix, startRow, startCol, feed);
                            return;
                        }
                        break;

                }
            }
            Console.WriteLine($"You won! You fed the snake.");
            Console.WriteLine($"Food eaten: {feed}");
            PrintMatrixWin(matrix);

            static void PrintMatrix(char[,] matrix, int startRow, int startCol, int feed)
            {
                matrix[startRow, startCol] = '.';
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {feed}");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (var j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }

                return;
            }
        }

        private static void Left(char[,] matrix, ref int startRow, ref int startCol, ref int feed)
        {
            if (matrix[startRow, startCol - 1] == '*')
            {
                feed++;

                matrix[startRow, startCol] = '.';
                matrix[startRow, startCol - 1] = 'S';
                startCol--;
            }
            else if (matrix[startRow, startCol - 1] == 'B')
            {
                matrix[startRow, startCol] = '.';
                matrix[startRow, startCol - 1] = '.';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'B')
                        {

                            startCol = j;
                            startRow = i;
                            matrix[startRow, startCol] = 'S';

                        }
                    }
                }

            }
            else if (matrix[startRow, startCol - 1] == '-')
            {

                matrix[startRow, startCol] = '.';
                matrix[startRow, startCol - 1] = 'S';
                startCol--;
            }
        }

        private static void Right(char[,] matrix, ref int startRow, ref int startCol, ref int feed)
        {
            if (matrix[startRow, startCol + 1] == '*')
            {
                feed++;
                matrix[startRow, startCol] = '.';
                matrix[startRow, startCol + 1] = 'S';
                startCol++;
            }
            else if (matrix[startRow, startCol + 1] == 'B')
            {

                matrix[startRow, startCol] = '.';
                matrix[startRow, startCol + 1] = '.';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'B')
                        {

                            startCol = j;
                            startRow = i;
                            matrix[startRow, startCol] = 'S';

                        }
                    }
                }

            }
            else if (matrix[startRow, startCol + 1] == '-')
            {

                matrix[startRow, startCol] = '.';
                matrix[startRow, startCol + 1] = 'S';
                startCol++;
            }
        }

        private static void Down(char[,] matrix, ref int startRow, ref int startCol, ref int feed)
        {
            if (matrix[startRow + 1, startCol] == '*')
            {
                feed++;

                matrix[startRow, startCol] = '.';
                matrix[startRow + 1, startCol] = 'S';
                startRow++;
            }
            else if (matrix[startRow + 1, startCol] == 'B')
            {

                matrix[startRow, startCol] = '.';
                matrix[startRow + 1, startCol] = '.';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'B')
                        {

                            startCol = j;
                            startRow = i;
                            matrix[startRow, startCol] = 'S';

                        }
                    }
                }

            }
            else if (matrix[startRow + 1, startCol] == '-')
            {

                matrix[startRow, startCol] = '.';
                matrix[startRow + 1, startCol] = 'S';
                startRow++;
            }
        }

        private static void Up(char[,] matrix, ref int startRow, ref int startCol, ref int feed)
        {
            if (matrix[startRow - 1, startCol] == '*')
            {
                feed++;

                matrix[startRow, startCol] = '.';
                matrix[startRow - 1, startCol] = 'S';
                startRow--;
            }
            else if (matrix[startRow - 1, startCol] == 'B')
            {


                matrix[startRow, startCol] = '.';
                matrix[startRow - 1, startCol] = '.';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'B')
                        {

                            startCol = j;
                            startRow = i;
                            matrix[startRow, startCol] = 'S';

                        }
                    }
                }

            }
            else if (matrix[startRow - 1, startCol] == '-')
            {

                matrix[startRow, startCol] = '.';
                matrix[startRow - 1, startCol] = 'S';
                startRow--;
            }
        }

        public static void PrintMatrixWin(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

