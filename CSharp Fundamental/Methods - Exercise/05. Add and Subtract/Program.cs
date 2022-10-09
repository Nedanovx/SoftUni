using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int sum = SumOftwoNumbers(number1, number2, number3);
            Console.WriteLine(sum);
        }
         static int SumOftwoNumbers(int number1, int number2, int number3)
        {
            return (number1 + number2) - number3;
        }
    }
}
