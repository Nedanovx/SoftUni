using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder symbol = new StringBuilder();
            foreach(char c in text)
            {
                if(Char.IsDigit(c))
                {
                    digit.Append(c);
                    
                }
                else if(Char.IsLetter(c))
                {
                    letter.Append(c);
                    
                }
                else
                {
                    symbol.Append(c);
                    
                }
            }
            Console.Write(digit);
            Console.WriteLine();
            Console.Write(letter);
            Console.WriteLine();
            Console.Write(symbol);
        }
    }
}
