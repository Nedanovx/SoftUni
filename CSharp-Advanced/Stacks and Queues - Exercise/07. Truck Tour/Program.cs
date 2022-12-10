using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fuelPumps = int.Parse(Console.ReadLine());
            var petrol = new Queue<int>();
            var distance = new Queue<int>();
            for (int i = 0; i < fuelPumps; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                petrol.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }

            for (int i = 0; i < fuelPumps; i++)
            {
                 int currentFuel = petrol.Peek();
                for (int j = 0; j < fuelPumps; j++)
                {
                    if (distance.Peek() <= currentFuel)
                    {
                        currentFuel -= distance.Peek();
                        if (j == fuelPumps - 1)
                        {
                            Console.WriteLine(i);
                            return;
                        }
                    }
                    else
                    {
                        for (int k = j; k < fuelPumps; k++)
                        {
                            petrol.Enqueue(petrol.Dequeue());
                            distance.Enqueue(distance.Dequeue());
                        }
                        break;
                    }
                    petrol.Enqueue(petrol.Dequeue());
                    distance.Enqueue(distance.Dequeue());
                    currentFuel += petrol.Peek();
                }
                petrol.Enqueue(petrol.Dequeue());
                distance.Enqueue(distance.Dequeue());
            }
        }
    }
}
