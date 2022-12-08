using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            for(int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
                if(stack.Count == 3)
                {
                    int firstNumber = int.Parse(stack.Pop());
                    char sing = char.Parse(stack.Pop());
                    int secondNumber = int.Parse(stack.Pop());
                    int result = 0;
                    if(sing =='+')
                    {
                        result = firstNumber + secondNumber;
                        stack.Push(result.ToString());
                    }
                    else if(sing =='-')
                    {
                        result = secondNumber - firstNumber;
                        stack.Push(result.ToString());
                    }
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
