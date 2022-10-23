using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int lastIndex = 0;
            int houseCount = 0;
            while (command != "Love!")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int jumpLength = int.Parse(cmdArg[1]);
                lastIndex += jumpLength;
                if (lastIndex >= neighborhood.Count || lastIndex < 0)
                {
                    lastIndex = 0;
                }

                if (neighborhood[lastIndex] != 0)
                {
                    neighborhood[lastIndex] -= 2;
                    if (neighborhood[lastIndex] == 0)
                    {
                        houseCount++;
                        Console.WriteLine($"Place {lastIndex} has Valentine's day.");
                    }

                }
                else
                {
                    Console.WriteLine($"Place {lastIndex} already had Valentine's day.");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {lastIndex}.");
            if(houseCount == neighborhood.Count)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Count - houseCount} places.");
            }
        }
    }

}

