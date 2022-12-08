using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> name = new Queue<string>();
            while(command != "End")
            {
                if(command != "Paid")
                {
                    name.Enqueue(command);
                }
                else
                {
                    while(name.Count > 0)
                    {
                        Console.WriteLine(name.Dequeue());
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{name.Count} people remaining.");
        }
    }
}
