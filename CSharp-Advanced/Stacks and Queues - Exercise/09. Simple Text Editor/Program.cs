using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> memory = new Stack<string>();
            memory.Push(string.Empty);
            StringBuilder text = new StringBuilder();
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                if(cmdArg[0] == "1")
                {
                    text.Append(cmdArg[1]);
                    memory.Push(text.ToString());
                }
                else if(cmdArg[0] == "2")
                {
                   text = text.Remove(text.Length - int.Parse(cmdArg[1]), int.Parse(cmdArg[1]));
                    memory.Push(text.ToString());
                }
                else if( cmdArg[0] == "3")
                {
                    if(int.Parse(cmdArg[1]) >= 0 && int.Parse(cmdArg[1]) <= text.Length)
                    {
                        Console.WriteLine(text[int.Parse(cmdArg[1])-1]);
                    }
                }
                else if (cmdArg[0] == "4")
                {
                    memory.Pop();
                    string previous = memory.Peek();
                    text = new StringBuilder(previous);
                }
            }
        }
    }
}
