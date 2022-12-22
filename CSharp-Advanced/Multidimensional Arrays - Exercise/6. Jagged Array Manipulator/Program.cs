using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];
            for(int i = 0; i < rows; i++)
            {
                double[] rowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();                               
                    matrix[i] = rowInfo;                
            }
            for(int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                if (matrix[i].Length == matrix[i+1].Length)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                        
                    }
                    for (int j = 0; j < matrix[i+1].Length; j++)
                    {
                        matrix[i+1][j] /= 2;

                    }
                }
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmdArg[0] == "Add")
                {
                    if(int.Parse(cmdArg[1]) >= 0 && int.Parse(cmdArg[1]) < rows && int.Parse(cmdArg[2]) >= 0 
                        && int.Parse(cmdArg[2]) < matrix[int.Parse(cmdArg[1])].Length)
                    {
                        matrix[int.Parse(cmdArg[1])][int.Parse(cmdArg[2])] += int.Parse(cmdArg[3]);
                    }
                }
                else if (cmdArg[0] == "Subtract")
                {
                    if (int.Parse(cmdArg[1]) >= 0 && int.Parse(cmdArg[1]) < rows && int.Parse(cmdArg[2]) >= 0
                        && int.Parse(cmdArg[2]) < matrix[int.Parse(cmdArg[1])].Length)
                    {
                        matrix[int.Parse(cmdArg[1])][int.Parse(cmdArg[2])] -= int.Parse(cmdArg[3]);
                    }
                }
                command = Console.ReadLine();
            }
            for(int row = 0; row < rows; row++)
            {
                for(int col=0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
