using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());
            Stack<int> bulletSize = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> lockSize = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int price = int.Parse(Console.ReadLine());
            int counterBullet = 0;
            while (bulletSize.Count > 0 && lockSize.Count > 0)
            {
                
                if (bulletSize.Peek() <= lockSize.Peek())
                {
                    counterBullet++;
                    bulletSize.Pop();
                    lockSize.Dequeue();
                    price -= priceOfBullet;
                    Console.WriteLine("Bang!");
                }
                else
                {
                    counterBullet++;
                    bulletSize.Pop();
                    price -= priceOfBullet;
                    Console.WriteLine("Ping!");
                }
                if (bulletSize.Count > 0 && counterBullet == sizeOfBarrel)
                {
                    Console.WriteLine("Reloading!");
                    counterBullet = 0;

                }
            }
            if (lockSize.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {lockSize.Count}");
            }
            else
            {
                Console.WriteLine($"{bulletSize.Count} bullets left. Earned ${price}");
            }
        }
    }
}
