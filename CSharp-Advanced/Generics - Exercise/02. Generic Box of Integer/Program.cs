using System;

namespace GenericBoxofInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.List.Add(input);

            }
            Console.WriteLine(box);
        }
    }
}
