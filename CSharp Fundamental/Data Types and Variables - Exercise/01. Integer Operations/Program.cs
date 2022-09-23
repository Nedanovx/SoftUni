using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int add =number1 + number2;
            int number3 = int.Parse(Console.ReadLine());
            int div = add / number3;
            int number4 = int.Parse(Console.ReadLine());
            int multiply = div * number4;
            Console.WriteLine(multiply);
        }
    }
}
