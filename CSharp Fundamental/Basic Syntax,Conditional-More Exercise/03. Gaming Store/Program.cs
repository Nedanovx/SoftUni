using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double sum = 0;
            double outFall4 = 39.99;
            double cs = 15.99;
            double zplinterZell = 19.99;
            double honored2 = 59.99;
            double roverWatch = 29.99;
            double roverWatchOriginalEdition = 39.99;
            string input = Console.ReadLine();
            while(input != "Game Time")
            {
                if (input == "OutFall 4")
                {
                    if (balance >= outFall4)
                    {
                        balance -= outFall4;
                        sum += outFall4;
                        Console.WriteLine($"Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "CS: OG")
                {
                    if (balance >= cs)
                    {
                        balance -= cs;
                        sum += cs;
                        Console.WriteLine($"Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (balance >= zplinterZell)
                    {
                        balance -= zplinterZell;
                        sum += zplinterZell;
                        Console.WriteLine($"Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Honored 2")
                {
                    if (balance >= honored2)
                    {
                        balance -= honored2;
                        sum += honored2;
                        Console.WriteLine($"Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (balance >= roverWatch)
                    {
                        balance -= roverWatch;
                        sum += roverWatch;
                        Console.WriteLine($"Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance >= roverWatchOriginalEdition)
                    {
                        balance -= roverWatchOriginalEdition;
                        sum += roverWatchOriginalEdition;
                        Console.WriteLine($"Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (balance>0)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${balance:f2}");
        }
    }
}
