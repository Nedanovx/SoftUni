using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] commandParams = input.Split();
                string command = commandParams[0];
                if(command == "Delete")
                {
                    int value = int.Parse(commandParams[1]);
                    numbers.RemoveAll(x => x == value);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(commandParams[1]);
                    int index = int.Parse(commandParams[2]);
                    numbers.Insert(index, value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
