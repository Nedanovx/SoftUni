using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Day / Age 0 <= age <= 18 18 < age <= 64 64 < age <= 122

            //Weekday           12$             18$             12$

            //Weekend           15$             20$             15$

            //Holiday           5$              12$             10$
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    break;
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }

        }
    }
}