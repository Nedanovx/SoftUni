using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            HashSet<string> list = new HashSet<string>();
            for(int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                list.Add(name);
            }
            foreach(string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
