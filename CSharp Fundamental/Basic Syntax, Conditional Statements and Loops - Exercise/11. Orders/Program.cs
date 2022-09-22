using System;
using System.Xml.Schema;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            while (n > 0)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                int countOfCapsules = int.Parse(Console.ReadLine());
                n--;
                double total = (day * countOfCapsules) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${total:f2}");
                sum+=total;
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
