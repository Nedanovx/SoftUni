using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();    
            string command = Console.ReadLine();
            while(command != "Reveal")
            {
                string[] cmdArg = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if(cmdType == "InsertSpace")
                {
                    int index = int.Parse(cmdArg[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (cmdType == "Reverse")
                {
                    string substring = cmdArg[1];
                    int startIndex = message.IndexOf(substring);
                    if(startIndex != -1)
                    {
                        message = message.Remove(startIndex, substring.Length);
                        
                        message += String.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                                       
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replacement = cmdArg[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
