using System;

namespace _7.Vending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalCoins = 0;
            double nuts = 2;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1;
            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    totalCoins+= coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }

            string products = Console.ReadLine();

            while (products != "End")
            {                  

                if(products == "Nuts")
                {
                    if (totalCoins >= 2)
                    {
                        Console.WriteLine($"Purchased nuts");
                        totalCoins -= nuts;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }               
                else if (products == "Water")
                {
                    if (totalCoins >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        totalCoins -= water;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Crisps")
                {
                    if (totalCoins >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        totalCoins -= crisps;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Soda")
                {
                    if (totalCoins >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        totalCoins -= soda;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Coke")
                {
                    if (totalCoins >= 1)
                    {
                        Console.WriteLine($"Purchased coke");
                        totalCoins -= coke;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }     
                else
                {
                    Console.WriteLine("Invalid product");
                }
                products = Console.ReadLine();
            }
            
            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
