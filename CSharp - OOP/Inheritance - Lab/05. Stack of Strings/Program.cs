using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            stackOfStrings.AddRange(new List<string>() { "o", "l", "l", "e", "H" });
            while(!stackOfStrings.IsEmpty())
            {
                Console.Write(stackOfStrings.Pop());
            }
        }
    }
}
