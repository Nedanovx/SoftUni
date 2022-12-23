using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> store = new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string[] cmdArg = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = cmdArg[0];
                string product = cmdArg[1];
                double price = double.Parse(cmdArg[2]);
                if(!store.ContainsKey(shop))
                {
                    store.Add(shop, new Dictionary<string, double>());
                }
                store[shop].Add(product, price);
                command = Console.ReadLine();
            }
            store = store.OrderBy(x => x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            foreach(var item in store)
            {
                Console.WriteLine($"{item.Key}->");
                foreach(var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
