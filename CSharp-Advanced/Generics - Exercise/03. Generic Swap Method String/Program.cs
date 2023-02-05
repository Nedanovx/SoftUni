using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for(int i = 0; i < numberOfInput; i++)
            {
                string input = Console.ReadLine();
                box.Item.Add(input);
            }
            int[] index = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstIndex = index[0];
            int secondIndex = index[1];
            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box);
        }
    }
}
