using System;

namespace _10.RageExp_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displeyPrice = double.Parse(Console.ReadLine());
            double total = 0;

            int headsetCount = numberOfGames / 2;
            int mouseCount = numberOfGames / 3;
            int keyboardCount = numberOfGames / 6;
            int displeyCount = numberOfGames / 12;
            total = headsetPrice*headsetCount + mousePrice*mouseCount + keyboardPrice*keyboardCount + displeyPrice*displeyCount;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
