using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for(int row = 0; row < size; row++)
            {
                char[] rowsInfo = Console.ReadLine().ToCharArray();                             
                    for(int col = 0; col < size; col++)
                    {
                        matrix[row, col] = rowsInfo[col];
                    }               
            }
            char wantedSymbol = char.Parse(Console.ReadLine());
            char currentSymbol;
            for(int row = 0; row < size; row++)
            {
                for(int col = 0; col < size ; col++)
                {
                    currentSymbol = matrix[row, col];
                    if(currentSymbol == wantedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{wantedSymbol} does not occur in the matrix");
        }
    }
}
