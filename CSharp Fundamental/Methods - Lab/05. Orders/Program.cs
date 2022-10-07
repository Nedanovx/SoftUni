using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            double price = 0;
            Price(product, quantity, price);
        }

        private static void Price(string product, double quantity, double price)
        {
            switch (product)
            {
                case "coffee":
                    price = quantity * 1.5;
                    Console.WriteLine($"{price:f2}");
                    break;

                case "water":
                    price = quantity * 1;
                    Console.WriteLine($"{price:f2}");
                    break;

                case "coke":
                    price = quantity * 1.4;
                    Console.WriteLine($"{price:f2}");
                    break;

                case "snacks":
                    price = quantity * 2;
                    Console.WriteLine($"{price:f2}");
                    break;
            }
        }
    }
}
