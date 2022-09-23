using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int startYield = int.Parse(Console.ReadLine());
           int days = 0;
           int total = 0;
          

            while ( startYield >= 100 )
            { 
                days++;
                int workConsume = startYield - 26;
                total = total + workConsume;
                startYield -= 10;              
            }
            if (total >= 26)
            {
                total -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}
