using System;

namespace _16._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            int expectedPlunder = int.Parse(Console.ReadLine());
            //Keep in mind that they attack more ships every third day and add additional plunder to their total gain,
            //which is 50% of the daily plunder. Every fifth day the pirates encounter a warship,
            //and after the battle, they lose 30% of their total plunder.
            double plunder = 0;
            for(int i = 1; i <= days; i++)
            {
                plunder+=(double)dailyPlunder;
                if(i % 3 == 0)
                {
                    plunder += dailyPlunder *0.5;
                }
                if(i % 5 == 0)
                {
                    plunder = plunder * 0.7;
                }
            }
            if(plunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(plunder / expectedPlunder)*100:f2}% of the plunder.");
            }
        }
    }
}
