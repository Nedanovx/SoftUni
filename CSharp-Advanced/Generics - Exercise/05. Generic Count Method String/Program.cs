using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            {
                for(int i = 0; i < numberOfInput; i++)
                {
                    box.Items.Add(Console.ReadLine());
                }
            }
            string comparingItem = Console.ReadLine();
            int result = box.ComparisonMethod(comparingItem);
            Console.WriteLine(result);
        }
    }
}
