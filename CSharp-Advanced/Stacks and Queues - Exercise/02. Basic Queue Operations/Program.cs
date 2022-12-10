using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cmdArg = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lengthOfStack = cmdArg[0];
            int elementsToRemove = cmdArg[1];
            int elementToLook = cmdArg[2];
            Queue<int> numbers = new Queue<int>(capacity: lengthOfStack);
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (int element in input)
            {
                numbers.Enqueue(element);
            }
            for (int i = 0; i < elementsToRemove; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Count > 0)
            {
                if (numbers.Contains(elementToLook))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine($"{numbers.Min()}");
                }
            }
            else
            {
                Console.WriteLine(numbers.Count);
            }
        }
    }
}
