using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < numberOfInput; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Item.Add(input);
            }
            int[] index = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstIndex = index[0];
            int secondIndex = index[1];
            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box);
        }
    }
}
