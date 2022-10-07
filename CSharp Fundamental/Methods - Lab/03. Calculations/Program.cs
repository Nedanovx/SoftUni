using System;
using System.Data;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
                
            if (command == "add")
            {
                AddOperation(number1, number2);
            }
            else if(command == "multiply")
            {
                MultiplyOperation(number1, number2);
            }
            else if (command == "subtract")
            {
                SubtractOperation(number1, number2);
            }
            else
            {
                DivideOperation(number1,number2);
            }

        }

        private static void DivideOperation(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
            
        }
        private static void SubtractOperation(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        private static void MultiplyOperation(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        private static void AddOperation(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
