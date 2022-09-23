using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0;
            int inpuLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < inpuLine; i++)
            {
                int water = int.Parse(Console.ReadLine());
                if (capacity + water <= 255)
                {
                    capacity += water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
