using System;

namespace _06.StrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copyNum = num;
            int facturialSum = 0;
            while (copyNum > 0)
            {
                int lastDigit = copyNum % 10;
                copyNum /= 10;
                int facturial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    facturial *= i;
                }
                facturialSum += facturial;
            }
            if (facturialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
