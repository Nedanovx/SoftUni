using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int originalValue = power;
            int targetCounter = 0;

            while (power >= distance)
            {
                power = power - distance;
                targetCounter++;

                if (power == originalValue * 0.50 && exhaustionFactor != 0)
                {
                    power = power / exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targetCounter);
        }
    }
}
