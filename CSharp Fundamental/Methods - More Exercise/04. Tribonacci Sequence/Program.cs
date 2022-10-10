using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] tribonacci = new int[num];
            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (num == 1)
            {
                Console.Write(1);
                return;
            }
            else if (num == 2)
            {
                Console.Write($"1 1");
                return;
            }

            else if (num == 3)
            {
                Console.Write($"1 1 2");
                return;
            }

            GetTribonacci(num, tribonacci);
        }

        private static void GetTribonacci(int num, int[] tribonacci)
        {
            for (int i = 3; i < num; i++)
            {
                tribonacci[0] = 1;
                tribonacci[1] = 1;
                tribonacci[2] = 2;

                int currentNumber = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                tribonacci[i] = currentNumber;

            }
            foreach (int number in tribonacci)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
