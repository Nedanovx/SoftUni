using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _11._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoin = 0;
            List<string> room = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            for(int i = 0; i < room.Count; i++)
            {
                string[] containsRoom = room[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdArg = containsRoom[0];
                int number = int.Parse(containsRoom[1]);
                if(cmdArg == "potion")
                {
                    
                    if (health > 0 && health <100 )
                    { 
                        int currentHealth = health;
                        health += number;
                        if (health > 100)
                        {
                            health = 100;
                            Console.WriteLine($"You healed for {100-currentHealth} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {number} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        
                    }                                     
                }
                else if (cmdArg == "chest")
                {
                    bitcoin += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {cmdArg}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {cmdArg}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return ;
                    }
                }
            }
            if(health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoin}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
