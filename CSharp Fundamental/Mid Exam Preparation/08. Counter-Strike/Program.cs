using System;

namespace _08._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int wonBattle = 0;
            while (command != "End of battle")
            {
                int enemy = int.Parse(command);
                if (energy >= enemy)
                {
                    wonBattle++;
                    energy -= enemy;
                    
                    if (wonBattle % 3 == 0)
                    {
                        energy += wonBattle;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattle} won battles and {energy} energy");
                    return;
                }
                command = Console.ReadLine();
            }
            if (energy <= 0)
            {
                Console.WriteLine($"Won battles: {wonBattle}. Energy left: 0");
            }
            else
            {
                Console.WriteLine($"Won battles: {wonBattle}. Energy left: {energy}");
            }
        }
    }
}
