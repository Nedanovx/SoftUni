using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                int[] cols = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = new int[cols.Length];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = cols[j];
                }
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] command = input.Split();
                int rowIndex = int.Parse(command[1]);
                int colIndex = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (command[0] == "Add")
                {

                    if (rowIndex >= 0 && rowIndex < jaggedArray.Length && colIndex >= 0 && colIndex < jaggedArray[rowIndex].Length)
                    {
                        jaggedArray[rowIndex][colIndex] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (rowIndex >= 0 && rowIndex < jaggedArray.Length && colIndex >= 0 && colIndex < jaggedArray[rowIndex].Length)
                    {
                        jaggedArray[rowIndex][colIndex] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                input = Console.ReadLine();
            }
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
