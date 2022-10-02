using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfString = int.Parse(Console.ReadLine());              
            int[] result = new int[numbersOfString];
            for (int i = 0; i < numbersOfString; i++)
            {
                string input = Console.ReadLine();
                char[] chars = input.ToCharArray();
                int sumOfChars = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    int encrypt = 0;
                    if (chars[j] == 'A' || chars[j] == 'a' || chars[j] == 'E' || chars[j] == 'e' || chars[j] == 'I' || chars[j] == 'i'
                         || chars[j] == 'O' || chars[j] == 'o' || chars[j] == 'U' || chars[j] == 'u')
                    {
                        encrypt = (int)chars[j];
                        encrypt *= chars.Length;
                        sumOfChars += encrypt;
                    }
                    else
                    {
                        encrypt = (int)chars[j];
                        encrypt /= chars.Length;
                        sumOfChars += encrypt;    
                    }
                    result[i] = sumOfChars;
                } 
            }
            Array.Sort(result);
            foreach (int index in result)
            {
                Console.WriteLine(index);
            }  
        }
    }
}
