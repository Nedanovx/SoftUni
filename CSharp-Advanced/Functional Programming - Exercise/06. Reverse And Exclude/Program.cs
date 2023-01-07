using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
            Func<int, int, bool> isDiv = (x, y) => x % y != 0;
            int y = int.Parse(Console.ReadLine());           
            numbers = numbers.Where(x => isDiv(x,y)).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
