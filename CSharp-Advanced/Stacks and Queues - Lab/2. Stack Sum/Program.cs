using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            string command = Console.ReadLine().ToLower();
            while(command != "end")
            {
                string[] cmdArg = command.Split();
                string cmdType = cmdArg[0];
                if(cmdType == "add")
                {
                    int firstnumber = int.Parse(cmdArg[1]);
                    int secondnumber = int.Parse(cmdArg[2]);
                    stack.Push(firstnumber);
                    stack.Push(secondnumber);
                }
                else if(cmdType == "remove")
                {
                    int count = int.Parse(cmdArg[1]);
                    if(count <= stack.Count)
                    {
                        for(int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
