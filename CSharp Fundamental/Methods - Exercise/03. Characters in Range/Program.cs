using System;


namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            if (symbol < symbol2)
            {
                PrintChars(symbol, symbol2);
            }
            else if (symbol > symbol2)
            {
                char changeValue = symbol;
                symbol = symbol2;
                symbol2 = changeValue;
                PrintChars(symbol, symbol2);
            }
        }

        private static void PrintChars(char symbol, char symbol2)
        {
            for (int i = symbol + 1; i < symbol2; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
