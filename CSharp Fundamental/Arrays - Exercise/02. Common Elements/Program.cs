using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split().ToArray();
            string[] arrayTwo = Console.ReadLine().Split().ToArray();
            foreach (string item in arrayTwo)
            {
                for(int i = 0; i < arrayOne.Length; i++)
                {
                    if ( arrayOne[i] == item)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}
