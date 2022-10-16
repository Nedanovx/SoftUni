using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] specialNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bomb = specialNumbers[0];
            int power = specialNumbers[1];

            if (numbers.Contains(bomb))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == bomb)
                    {
                        for (int j = 1; j <= power; j++)
                        {
                            int index = i - j;
                            if (index >= 0)
                            {

                                numbers[index] = 0;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        for (int j = 1; j <= power; j++)
                        {
                            int index = i + j;
                            if (index <= numbers.Count - 1)
                            {
                                numbers[index] = 0;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        numbers[i] = 0;
                    }

                }
                Console.WriteLine(numbers.Sum());
            }

        }
    }
}
