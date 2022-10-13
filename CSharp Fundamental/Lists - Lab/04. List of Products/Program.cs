﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < number; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{products[i]}");
                }
            
        }
    }
}
