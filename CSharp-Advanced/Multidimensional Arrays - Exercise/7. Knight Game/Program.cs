using System;
using System.Linq;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            if(rows < 3)
            {
                Console.WriteLine("0");
                return;
            }
            char[,] matrix = new char[rows, rows];
            for(int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for(int j = 0; j < rows; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int knightsRemoved = 0;
            while(true)
            {
                int countMostAttaking = 0;
                int rowIndex = 0;
                int colIndex = 0;
                for(int row = 0; row < rows; row++)
                {
                    for(int col = 0; col < rows; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attakedknight = CountAttakedKnights(row, col, rows, matrix);
                            if(attakedknight > countMostAttaking)
                            {
                                countMostAttaking = attakedknight;
                                rowIndex = row;
                                colIndex = col;
                            }
                        }
                    }
                }
                if(countMostAttaking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowIndex, colIndex] = '0';
                    knightsRemoved++;
                }
            }
            Console.WriteLine(knightsRemoved);
        }

        private static int CountAttakedKnights(int row, int col, int rows, char[,] matrix)
        {
            int attakedKnights = 0;
            if(IsCellValid(row - 1, col - 2, rows))
            {
                if(matrix[row - 1, col - 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            if (IsCellValid(row + 1, col - 2, rows))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            if (IsCellValid(row - 1, col + 2, rows))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            if (IsCellValid(row + 1, col + 2, rows))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            if (IsCellValid(row - 2, col - 1, rows))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attakedKnights++;
                }
            }

            if (IsCellValid(row - 2, col + 1, rows))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attakedKnights++;
                }
            }

            if (IsCellValid(row + 2, col - 1, rows))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attakedKnights++;
                }
            }

            if (IsCellValid(row + 2, col + 1, rows))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attakedKnights++;
                }
            }
            return attakedKnights;
        }
        private static bool IsCellValid(int row, int col, int rows)
        {
            return row >= 0 && row < rows && col >= 0 && col < rows;
        }
    }
}
