using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gardenSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = gardenSize[0];
            int cols = gardenSize[1];
            int[,] garden = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    garden[i, j] = 0;
                }
            }
            string command = Console.ReadLine();
            List<string> coordinates = new List<string>();
            while(command != "Bloom Bloom Plow")
            {
                string[] cmd = command.Split();
                int currentRow = int.Parse(cmd[0]);
                int currentCol = int.Parse(cmd[1]);
                if(currentRow < 0 || currentRow > garden.GetLength(0) && currentCol < 0 || currentCol > garden.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    coordinates.Add($"{currentRow} {currentCol}");
                }
                command = Console.ReadLine();
            }
             foreach(string coord in coordinates)
            {
                string[] currentCoordinates = coord.Split();
                int row = int.Parse(currentCoordinates[0]);
                int col = int.Parse(currentCoordinates[1]);
                garden[row, col] = -1;
                for (int i = 0; i < rows; i++)
                {
                    garden[i, col] += 1;
                }
                for(int i = 0; i < cols; i++)
                {
                    garden[row,i] +=1;
                }
            }
             for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
