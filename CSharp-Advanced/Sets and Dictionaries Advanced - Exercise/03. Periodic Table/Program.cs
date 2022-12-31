using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();
            for(int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
               elements.UnionWith(input);
            }
            Console.WriteLine(String.Join(" ", elements.OrderBy(x=>x)));
        }
    }
}
