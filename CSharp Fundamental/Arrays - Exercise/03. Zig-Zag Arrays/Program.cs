using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] evenArr=new int[number];
            int[] oddArr=new int[number];
            for(int i=0; i<number; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    evenArr[i] = numbers[0];
                    oddArr[i] = numbers[1];
                }
                else
                {
                    evenArr[i] = numbers[1];
                    oddArr[i] = numbers[0];
                }
                
            }
            Console.WriteLine(String.Join(" ", evenArr));
            Console.WriteLine(String.Join(" ", oddArr));
        }
    }
}
