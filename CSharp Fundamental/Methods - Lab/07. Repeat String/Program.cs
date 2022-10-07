using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            PrintAgain(input, repeat);
        }

        private static void PrintAgain(string input, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(input);
            }
        }
    }
}
