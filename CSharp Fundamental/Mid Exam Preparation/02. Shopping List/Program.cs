using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while(command != "Go Shopping!")
            {
                string[]cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = cmdArg[0];
                string item = cmdArg[1];
                if (commandType == "Urgent")
                {
                    if (!products.Contains(item))
                    {
                        products.Insert(0, item);
                    }                  
                }
                else if (commandType == "Unnecessary")
                {
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }                  
                }
                else if (commandType == "Correct")
                {
                    string newItem = cmdArg[2];
                    if (products.Contains(item))
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i] == item)
                            {
                                products[i] = newItem;
                                break;
                            }
                        }
                    }
                }
                else if (commandType == "Rearrange")
                {
                    if(products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }                  
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", products));
        }
    }
}
