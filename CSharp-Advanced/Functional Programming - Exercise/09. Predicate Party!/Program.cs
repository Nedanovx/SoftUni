using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            
            while(command != "Party!")
            {
                string[] cmdArg = command.Split();
                string cmdType = cmdArg[0];
                string operation = cmdArg[1];
                string value = cmdArg[2];
                if(cmdType == "Double")
                {
                    guest.FindAll(GetPredicate(operation, value));
                    List<string> names = guest.FindAll(GetPredicate(operation, value));
                    int index =guest.FindIndex(GetPredicate(operation, value));
                    if(index != -1)
                    {
                        guest.InsertRange(index, names);
                    }                  
                }
                else
                {
                    guest.RemoveAll(GetPredicate(operation, value));
                }

                command = Console.ReadLine();             
            }
            if(guest.Count > 0)
            {
                Console.Write($"{String.Join(", ", guest)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string operation, string value)
        {
            if(operation == "StartsWith")
            {
                return x => x.StartsWith(value);
            }
            
            if(operation == "EndsWith")
            {
                return x => x.EndsWith(value);
            }
            
            int lenght = int.Parse(value);
            return x => x.Length == lenght;
        }
    }
}
