using System;
using System.Linq;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            if (chars.Length % 2 != 0)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    for (int j = chars.Length; j >= i; j--)
                    {
                        if (j == i)
                        {
                            Console.WriteLine(chars[j]);
                        }
                    }
                }
            }
            
        }
    }
}
