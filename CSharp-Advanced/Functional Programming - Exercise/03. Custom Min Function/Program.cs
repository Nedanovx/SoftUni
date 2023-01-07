using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minNumber = number =>
            {
                int minValue = int.MaxValue;
                foreach(int value in number)
                {
                    if(value < minValue)
                    {
                        minValue = value;
                    }
                }
                return minValue;
            };
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = minNumber(inputNumbers);
            Console.WriteLine(result);
        }
    }
}
