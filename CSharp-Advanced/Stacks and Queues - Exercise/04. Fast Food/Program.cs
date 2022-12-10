using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Console.WriteLine(orders.Max());
            while (orders.Count > 0)
            {
                if (food - orders.Peek() >= 0)
                {
                    food -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
