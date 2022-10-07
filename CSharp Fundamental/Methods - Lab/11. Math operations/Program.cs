using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            double result = 0;
            result = NewMethod(number1, operation, number2, result);
            Console.WriteLine($"{result}");
        }

        private static double NewMethod(int number1, string operation, int number2, double result)
        {
            switch (operation)
            {
                case "/":
                    result = number1 / number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
            }

            return result;
        }
    }
}

