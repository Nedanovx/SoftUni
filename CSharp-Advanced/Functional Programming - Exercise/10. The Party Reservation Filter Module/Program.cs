using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            Dictionary<string, Predicate<string>> allFilters = new Dictionary<string, Predicate<string>>();
            while (command != "Print")
            {
                string[] cmdArg = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                string operation = cmdArg[1];
                string value = cmdArg[2];
                if(cmdType == "Add filter")
                {
                    allFilters.Add(operation + value, GetPredicate(operation, value));
                }
                else
                {
                    allFilters.Remove(operation + value);
                }

                command = Console.ReadLine();
            }
           foreach(var filter in allFilters)
            {
                guest.RemoveAll(filter.Value);
            }
            Console.WriteLine(string.Join(" ", guest));
        }

        private static Predicate<string> GetPredicate(string operation, string value)
        {
            if (operation == "Starts with")
            {
                return x => x.StartsWith(value);
            }

            if (operation == "Ends with")
            {
                return x => x.EndsWith(value);
            }
            
            if(operation == "Contains")
            {
                return x => x.Contains(value);
            }

            int lenght = int.Parse(value);
            return x => x.Length == lenght;
        }
    }
}
