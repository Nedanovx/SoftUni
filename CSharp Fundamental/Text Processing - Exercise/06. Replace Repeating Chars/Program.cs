using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char firstChar = text[0];
            Console.Write(firstChar);
            for(int i = 1; i < text.Length; i++)
            {
                char currChar = text[i];
                if(firstChar != currChar)
                {
                    firstChar = currChar;
                    Console.Write(firstChar);
                }
            }
        }
    }
}
