using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string input = Console.ReadLine();
            if (inputType == "int")
            {
                int num = int.Parse(input);
                MyltiplyByTwo(num);
            }
            else if (inputType == "real")
            {
                double num = double.Parse(input);
                MyltiplyByOnePointFive(num);
            }
            else if (inputType == "string")
            {
                SurroundInputWithChar(input);
            }
        }

        private static void SurroundInputWithChar(string input)
        {
            Console.WriteLine($"${input}$");
        }

        private static void MyltiplyByOnePointFive(double num)
        {
            
            Console.WriteLine($"{num*1.5:f2}");
        }

        private static void MyltiplyByTwo(int num)
        {
            
            Console.WriteLine(num*2);
        }
    }
}
