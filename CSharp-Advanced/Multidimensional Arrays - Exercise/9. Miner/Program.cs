using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[rows, rows];
            for (int row = 0; row < rows; row++)
            {
                char[] rowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = rowInfo[col];
                }
            }
            int startRow = 0;
            int startCol = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    if(matrix[i, j] == 's')
                    {
                        startRow = i;
                        startCol = j;
                    }
                }
            }          
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == "left")
                {
                    if(startCol - 1 >= 0)
                    {
                        startCol -= 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            return;
                        }
                        else if(matrix[startRow, startCol] == 'c')
                        {
                            matrix[startRow, startCol] = '*';
                        }                        
                    }
                }
                else if (command[i] == "right")
                {
                    if (startCol + 1 < matrix.GetLength(1))
                    {
                        startCol += 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            return;
                        }
                        else if (matrix[startRow, startCol] == 'c')
                        {
                            matrix[startRow, startCol] = '*';
                        }
                    }
                }
                else if (command[i] == "up")
                {
                    if (startRow - 1 >= 0)
                    {
                        startRow -= 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            return;
                        }
                        else if (matrix[startRow, startCol] == 'c')
                        {
                            matrix[startRow, startCol] = '*';
                        }
                    }
                }
                else if (command[i] == "down")
                {
                    if (startRow + 1 < matrix.GetLength(0))
                    {
                        startRow += 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            return;
                        }
                        else if (matrix[startRow, startCol] == 'c')
                        {
                            matrix[startRow, startCol] = '*';
                        }
                    }
                }
            }
            int coal = 0;
            foreach(char symbol in matrix)
            {
                if(symbol == 'c')
                {
                    coal++;
                }
            }
            if(coal > 0)
            {
                Console.WriteLine($"{coal} coals left. ({startRow}, {startCol})");
            }
            else
            {
                Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
            }
        }
    }
}
