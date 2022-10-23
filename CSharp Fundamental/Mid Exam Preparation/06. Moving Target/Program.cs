using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArg = command.Split(" ");
                string cmdType = cmdArg[0];
                int index = int.Parse(cmdArg[1]);
                int values =  int.Parse(cmdArg[2]);
                if(cmdType == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= values;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if ( cmdType == "Add")
                {
                    if(index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, values);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (cmdType == "Strike")
                {
                    if(index-values >= 0 && index+values < targets.Count)
                    {
                        targets.RemoveRange(index-values, values*2+1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
