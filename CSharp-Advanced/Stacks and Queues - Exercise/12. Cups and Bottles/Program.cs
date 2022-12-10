using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> bottle = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;
            while (cups.Count > 0 && bottle.Count > 0)
            {
                int currentCup = cups.Peek();
                int currentBottle = bottle.Peek();
                if (currentBottle == currentCup)
                {
                    cups.Dequeue();
                    bottle.Pop();
                }
                else if (currentCup > currentBottle)
                {
                    while (currentCup > 0)
                    {
                        currentCup -= bottle.Pop();

                    }
                    wastedWater += Math.Abs(currentCup);
                    cups.Dequeue();
                }
                else if (currentCup < currentBottle)
                {
                    wastedWater += currentBottle - currentCup;
                    bottle.Pop();
                    cups.Dequeue();
                }
            }
            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottle)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
