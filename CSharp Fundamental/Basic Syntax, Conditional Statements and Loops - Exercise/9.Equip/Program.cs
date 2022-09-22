using System;

namespace _9.Equip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priseOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());
            double total = 0;
            double countOfLightsabers = Math.Ceiling((students) * 1.1);           
            int freeBelt = 0;
            if (students / 6 > 0)
            {
                freeBelt = students / 6;
            }
            total = (students - freeBelt) * priceOfBelt + students * priceOfRobe + countOfLightsabers * priseOfLightsaber;
            if(total > budget)
            {
                
                Console.WriteLine($"John will need {total-budget:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
        }
    }
}
