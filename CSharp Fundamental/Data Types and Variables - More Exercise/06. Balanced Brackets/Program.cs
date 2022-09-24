using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int openingBracket = 0;
            int closedBracket = 0;
            string latest = "";
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                if (latest == input)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                if (input == ")")
                {
                    openingBracket++;
                    closedBracket--;
                    latest = input;

                }
                else if (input == "(")
                {
                    closedBracket++;
                    openingBracket--;
                    latest = input;
                }
            }
            if (openingBracket == closedBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}