using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNum = number;
            int sum = 0;
            while (copyNum > 0)
            {
                int lastDigit = copyNum % 10;
                sum += lastDigit;
                copyNum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
