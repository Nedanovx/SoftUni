using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            int moves = 0;
            while (command != "end")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int index1 = int.Parse(cmdArg[0]);
                int index2 = int.Parse(cmdArg[1]);
                moves++;
                if (index1 == index2 || index1 < 0 || index2 < 0 || index1 >= elements.Count || index2 >= elements.Count)
                {

                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    elements.Insert((elements.Count / 2), $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[index1] == elements[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    if (index1 > index2)
                    {
                        elements.RemoveAt(index1);
                        elements.RemoveAt(index2);
                    }
                    else
                    {
                        elements.RemoveAt(index2);
                        elements.RemoveAt(index1);
                    }
                }
                else if(elements[index1] != elements[index2])
                {
                    Console.WriteLine("Try again!");
                }
                
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
                command = Console.ReadLine();
            }
            if (command == "end" && elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
