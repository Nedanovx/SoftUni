using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> orders = new Dictionary<string, double[]>();
            string input = Console.ReadLine();
            while(input != "buy")
            {
                string[] inputArg = input.Split(' ');
                string product = inputArg[0];
                double price = double.Parse(inputArg[1]);
                int quantity = int.Parse(inputArg[2]);
                
                if (!orders.ContainsKey(product))
                {
                    orders[product] = new double[2];
                    orders[product][0] = price;
                    orders[product][1] = quantity;
                }
                else
                {
                    orders[product][0] = price;
                    orders[product][1] += quantity;
                }
                input = Console.ReadLine();

               
            }
            foreach (var item in orders)
            {
                double total = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {total:F2}");
            }
        }
    }
}
