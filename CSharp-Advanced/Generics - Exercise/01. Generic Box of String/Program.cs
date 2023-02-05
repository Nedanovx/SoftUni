using System;
using System.Collections.Generic;

namespace GenericBoxofString
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for(int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                box.List.Add(input);
                
            }
            Console.WriteLine(box);
        }
    }
}
