using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
           CustomStack<string> customStack = new CustomStack<string>();
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] cmdArg = command.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if(cmdType == "Push")
                {
                    foreach(var item in cmdArg.Skip(1))
                    {
                        customStack.Push(item);
                    }
                }
                else
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
               
                command = Console.ReadLine();
            }
            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
