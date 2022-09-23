using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isSpecialNum = true;

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int currentNumber = i;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;

                    currentNumber = currentNumber / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecialNum);               
            }
        }
    }
}
