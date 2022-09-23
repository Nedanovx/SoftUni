using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int inputNumber = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= inputNumber; i++)
            {
                int sum = 0;
                int currentNumber = i;
                
                while (currentNumber > 0)
                {
                    sum+=currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
