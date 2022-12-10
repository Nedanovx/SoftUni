using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach(char symbol in input)
            {
                if(stack.Count > 0)
                {
                    if(stack.Peek() == '[' && symbol ==']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if(stack.Peek() == '(' && symbol ==')')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if(stack.Peek() == '{' && symbol =='}')
                    {
                        stack.Pop();
                        continue;
                    }
                }                              
                    stack.Push(symbol);               
            }
            if(stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
