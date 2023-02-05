using System;

namespace _11._Selling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int startRow = 0;
            int startCol = 0;
            char[,] matrix = new char[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                string rowInfo = Console.ReadLine();
                for (int j = 0; j < rowInfo.Length; j++)
                {
                    matrix[i, j] = rowInfo[j];
                    if (matrix[i, j] == 'S')
                    {
                        startRow = i;
                        startCol = j;
                    }
                }
            }
            int sum = 0;
            while (sum < 50)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        if (startRow - 1 >= 0)
                        {
                            Up(ref startRow, ref startCol, matrix, ref sum);
                        }
                        else
                        {
                            matrix[startRow, startCol] = '-';
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                    case "down":
                        if (startRow + 1 < matrix.GetLength(0))
                        {
                            Down(ref startRow, ref startCol, matrix, ref sum);
                        }
                        else
                        {
                            matrix[startRow, startCol] = '-';
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                    case "left":
                        if (startCol - 1 >= 0)
                        {
                            Left(ref startRow, ref startCol, matrix, ref sum);
                        }
                        else
                        {
                            matrix[startRow, startCol] = '-';
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                    case "right":
                        if (startCol + 1 < matrix.GetLength(1))
                        {
                            Right(ref startRow, ref startCol, matrix, ref sum);
                        }
                        else
                        {
                            matrix[startRow, startCol] = '-';
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("Good news! You succeeded in collecting enough money!");
            Console.WriteLine($"Money: {sum}");
            PrintMatrix(matrix);
        }
        private static void Right(ref int startRow, ref int startCol, char[,] matrix, ref int sum)
        {

            if (matrix[startRow, startCol + 1] == '-')
            {
                matrix[startRow, startCol] = '-';
                startCol += 1;
                matrix[startRow, startCol] = 'S';
            }
            else if (matrix[startRow, startCol + 1] == 'O')
            {
                matrix[startRow, startCol] = '-';
                startCol += 1;
                matrix[startRow, startCol] = 'S';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'O')
                        {
                            matrix[startRow, startCol] = '-';
                            startRow = i;
                            startCol = j;
                            matrix[startRow, startCol] = 'S';
                        }
                    }
                }
            }
            else if (char.IsDigit(matrix[startRow, startCol + 1]))
            {
                int value = (int)matrix[startRow, startCol + 1] - 48;
                sum += value;
                matrix[startRow, startCol] = '-';
                startCol += 1;
                matrix[startRow, startCol] = 'S';
            }

        }
        private static void Down(ref int startRow, ref int startCol, char[,] matrix, ref int sum)
        {

            if (matrix[startRow + 1, startCol] == '-')
            {
                matrix[startRow, startCol] = '-';
                startRow += 1;
                matrix[startRow, startCol] = 'S';
            }
            else if (matrix[startRow + 1, startCol] == 'O')
            {
                matrix[startRow, startCol] = '-';
                startRow += 1;
                matrix[startRow, startCol] = 'S';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'O')
                        {
                            matrix[startRow, startCol] = '-';
                            startRow = i;
                            startCol = j;
                            matrix[startRow, startCol] = 'S';
                        }
                    }
                }
            }
            else if (char.IsDigit(matrix[startRow + 1, startCol]))
            {
                int value = (int)matrix[startRow + 1, startCol] - 48;
                sum += value;
                matrix[startRow, startCol] = '-';
                startRow += 1;
                matrix[startRow, startCol] = 'S';
            }
        }
        private static void Left(ref int startRow, ref int startCol, char[,] matrix, ref int sum)
        {
            if (matrix[startRow, startCol - 1] == '-')
            {
                matrix[startRow, startCol] = '-';
                startCol -= 1;
                matrix[startRow, startCol] = 'S';
            }
            else if (matrix[startRow, startCol - 1] == 'O')
            {
                matrix[startRow, startCol] = '-';
                startCol -= 1;
                matrix[startRow, startCol] = 'S';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'O')
                        {
                            matrix[startRow, startCol] = '-';
                            startRow = i;
                            startCol = j;
                            matrix[startRow, startCol] = 'S';
                        }
                    }
                }
            }
            else if (char.IsDigit(matrix[startRow, startCol - 1]))
            {
                int value = (int)matrix[startRow, startCol - 1] - 48;
                sum += value;
                matrix[startRow, startCol] = '-';
                startCol -= 1;
                matrix[startRow, startCol] = 'S';
            }
        }

        private static void Up(ref int startRow, ref int startCol, char[,] matrix, ref int sum)
        {

            if (matrix[startRow - 1, startCol] == '-')
            {
                matrix[startRow, startCol] = '-';
                startRow -= 1;
                matrix[startRow, startCol] = 'S';
            }
            else if (matrix[startRow - 1, startCol] == 'O')
            {
                matrix[startRow, startCol] = '-';
                startRow -= 1;
                matrix[startRow, startCol] = 'S';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'O')
                        {
                            matrix[startRow, startCol] = '-';
                            startRow = i;
                            startCol = j;
                            matrix[startRow, startCol] = 'S';
                        }
                    }
                }
            }
            else if (char.IsDigit(matrix[startRow - 1, startCol]))
            {
                int value = (int)matrix[startRow - 1, startCol] - 48;
                sum += value;
                matrix[startRow, startCol] = '-';
                startRow -= 1;
                matrix[startRow, startCol] = 'S';
            }

        }

        public static void PrintMatrix(char[,] matrix)
        {
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

