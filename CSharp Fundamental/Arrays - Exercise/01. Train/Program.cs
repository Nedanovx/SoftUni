using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];
            int people = 0;
            for (int i = 0; i < wagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                people += train[i];
            }
            for (int i = 0; i < wagons; i++)
            {
                Console.Write($"{train[i]} ");
                
            }
            Console.WriteLine();
            Console.WriteLine(people);
        }
    }
}
