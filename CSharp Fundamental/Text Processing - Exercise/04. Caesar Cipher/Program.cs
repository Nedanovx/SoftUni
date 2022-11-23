using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            for(int i = 0; i < input.Length; i++)
            {              
                    int newSymbol = input[i] + 3;
                    char currNewSymbol = (char)newSymbol;     
                    text.Append(currNewSymbol);               
            }
            Console.WriteLine(text);
        }
    }
}
