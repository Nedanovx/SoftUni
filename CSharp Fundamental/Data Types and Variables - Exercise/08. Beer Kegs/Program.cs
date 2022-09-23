using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string biggestKeg =string.Empty;
            double maxKeg = double.MinValue;
            for (int i = 0; i < inputNumber; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                
                if(volume > maxKeg)
                {
                    maxKeg = volume;
                    biggestKeg = model;
                }   
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
