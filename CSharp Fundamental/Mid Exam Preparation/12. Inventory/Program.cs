using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "Craft!")
            {
                string[] cmdArg = command.Split(" - ");
                string cmdType = cmdArg[0];
                string item = cmdArg[1];
                if(cmdType == "Collect")
                {
                    if(!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }                  
                }
                else if (cmdType == "Drop")
                {
                    if(inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }                                                                            
                }
                else if (cmdType == "Combine Items")
                {
                    string[] combineItem = cmdArg[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = combineItem[0];
                    string newItem = combineItem[1];
                    if (inventory.Contains(oldItem))
                    {
                        if (inventory.IndexOf(oldItem) == inventory.Count-1)
                        {
                            inventory.Add(newItem);
                        }
                        else
                        {
                            inventory.Insert(inventory.IndexOf(oldItem)+1, newItem);
                        }
                    }
                                                          
                }
                else if (cmdType == "Renew")
                {
                    if(inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }                                                            
                }
                command = Console.ReadLine();
            }           
                Console.WriteLine(string.Join(", ", inventory));           
        }
    }
}
