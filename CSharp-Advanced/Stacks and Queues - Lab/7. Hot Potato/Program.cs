using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split().ToArray());
            int count = int.Parse(Console.ReadLine());
            int tosses = 1;
            while (kids.Count > 1)
            {
                
                string currentKid = kids.Dequeue();
                if(tosses == count)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    tosses = 1;
                    continue;
                }
                tosses++;
                kids.Enqueue(currentKid);
                
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
