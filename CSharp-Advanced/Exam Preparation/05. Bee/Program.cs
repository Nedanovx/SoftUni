using System;
using System.Linq;

namespace _05._Bee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            int startRow = 0;
            int startCol = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                string rowInfo = Console.ReadLine();
                for (int j = 0; j < rowInfo.Length; j++)
                {
                    matrix[i, j] = rowInfo[j];
                    if (matrix[i, j] == 'B')
                    {
                        startRow = i;
                        startCol = j;
                    }
                }
            }
            string command = Console.ReadLine();
            int flowers = 0;
            while (command != "End")
            {
                if (command == "up")
                {
                    if (startRow - 1 < 0)
                    {
                        matrix[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        PrintMatrix(matrix, flowers);
                        return;
                    }
                    else
                    {
                        if (matrix[startRow - 1, startCol] == '.')
                        {
                            matrix[startRow, startCol] = '.';
                            startRow--;
                            matrix[startRow, startCol] = 'B';
                        }
                        else if (matrix[startRow - 1, startCol] == 'f')
                        {
                            matrix[startRow, startCol] = '.';
                            startRow--;
                            matrix[startRow, startCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[startRow - 1, startCol] == 'O')
                        {
                            matrix[startRow, startCol] = '.';
                            startRow--;
                            if (startRow - 1 < 0)
                            {
                                Console.WriteLine("The bee got lost!");
                                PrintMatrix(matrix, flowers);
                                return;
                            }
                            else
                            {
                                if (matrix[startRow - 1, startCol] == '.')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startRow--;
                                    matrix[startRow, startCol] = 'B';
                                }
                                else if (matrix[startRow - 1, startCol] == 'f')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startRow--;
                                    matrix[startRow, startCol] = 'B';
                                    flowers++;
                                }

                            }
                        }
                    }
                }
                else if (command == "down")
                {
                    if (startRow + 1 >= matrix.GetLength(0))
                    {
                        matrix[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        PrintMatrix(matrix, flowers);
                        return;
                    }
                    else
                    {
                        if (matrix[startRow + 1, startCol] == '.')
                        {
                            matrix[startRow, startCol] = '.';
                            startRow++;
                            matrix[startRow, startCol] = 'B';
                        }
                        else if (matrix[startRow + 1, startCol] == 'f')
                        {
                            matrix[startRow, startCol] = '.';
                            startRow++;
                            matrix[startRow, startCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[startRow + 1, startCol] == 'O')
                        {
                            matrix[startRow, startCol] = '.';
                            startRow++;
                            if (startRow + 1 >= matrix.GetLength(0))
                            {
                                Console.WriteLine("The bee got lost!");
                                PrintMatrix(matrix, flowers);
                                return;
                            }
                            else
                            {
                                if (matrix[startRow + 1, startCol] == '.')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startRow++;
                                    matrix[startRow, startCol] = 'B';
                                }
                                else if (matrix[startRow + 1, startCol] == 'f')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startRow++;
                                    matrix[startRow, startCol] = 'B';
                                    flowers++;
                                }

                            }
                        }
                    }
                }
                else if (command == "left")
                {
                    if (startCol - 1 < 0)
                    {
                        matrix[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        PrintMatrix(matrix, flowers);
                        return;
                    }
                    else
                    {
                        if (matrix[startRow, startCol - 1] == '.')
                        {
                            matrix[startRow, startCol] = '.';
                            startCol--;
                            matrix[startRow, startCol] = 'B';
                        }
                        else if (matrix[startRow, startCol - 1] == 'f')
                        {
                            matrix[startRow, startCol] = '.';
                            startCol--;
                            matrix[startRow, startCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[startRow, startCol - 1] == 'O')
                        {
                            matrix[startRow, startCol] = '.';
                            startCol--;
                            if (startCol - 1 > 0)
                            {
                                Console.WriteLine("The bee got lost!");
                                PrintMatrix(matrix, flowers);
                                return;
                            }
                            else
                            {
                                if (matrix[startRow, startCol - 1] == '.')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startCol--;
                                    matrix[startRow, startCol] = 'B';
                                }
                                else if (matrix[startRow, startCol - 1] == 'f')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startCol--;
                                    matrix[startRow, startCol] = 'B';
                                    flowers++;
                                }

                            }
                        }
                    }
                }
                else if (command == "right")
                {
                    if (startCol + 1 >= matrix.GetLength(1))
                    {
                        matrix[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        PrintMatrix(matrix, flowers);
                        return;
                    }
                    else
                    {
                        if (matrix[startRow, startCol + 1] == '.')
                        {
                            matrix[startRow, startCol] = '.';
                            startCol++;
                            matrix[startRow, startCol] = 'B';
                        }
                        else if (matrix[startRow, startCol + 1] == 'f')
                        {
                            matrix[startRow, startCol] = '.';
                            startCol++;
                            matrix[startRow, startCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[startRow, startCol + 1] == 'O')
                        {
                            matrix[startRow, startCol] = '.';
                            startCol++;
                            if (startCol + 1 >= matrix.GetLength(1))
                            {
                                Console.WriteLine("The bee got lost!");
                                PrintMatrix(matrix, flowers);
                                return;
                            }
                            else
                            {
                                if (matrix[startRow, startCol + 1] == '.')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startCol++;
                                    matrix[startRow, startCol] = 'B';
                                }
                                else if (matrix[startRow, startCol + 1] == 'f')
                                {
                                    matrix[startRow, startCol] = '.';
                                    startCol++;
                                    matrix[startRow, startCol] = 'B';
                                    flowers++;
                                }

                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            PrintMatrix(matrix, flowers);
        }

        public static void PrintMatrix(char[,] matrix, int flowers)
        {
            if (flowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}

