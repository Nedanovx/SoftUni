using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            for(int i = 0; i < matrixSize[0]; i++)
            {
                string[] rowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for(int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }
            string command = Console.ReadLine();           
            while (command != "END")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmdArg[0] != "swap" || cmdArg.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (int.Parse(cmdArg[1]) < 0 || int.Parse(cmdArg[1]) >= matrix.GetLength(0) || int.Parse(cmdArg[2]) < 0
                    || int.Parse(cmdArg[2]) >= matrix.GetLength(1) || int.Parse(cmdArg[3]) < 0 || int.Parse(cmdArg[3]) >= matrix.GetLength(0)
                    || int.Parse(cmdArg[4]) >= matrix.GetLength(1) || int.Parse(cmdArg[4]) <0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string currentIndex = string.Empty;
                    currentIndex = matrix[int.Parse(cmdArg[1]), int.Parse(cmdArg[2])];
                    matrix[int.Parse(cmdArg[1]), int.Parse(cmdArg[2])] = matrix[int.Parse(cmdArg[3]), int.Parse(cmdArg[4])];
                    matrix[int.Parse(cmdArg[3]), int.Parse(cmdArg[4])] = currentIndex;
                    for(int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for(int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i,j]} ");
                        }
                        Console.WriteLine();
                    }
                    currentIndex = string.Empty;
                }
                command = Console.ReadLine();
            }
            
        }
    }
}
