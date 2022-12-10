using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rack = int.Parse(Console.ReadLine());
            int countRack = 0;
            int sumClothes = 0;
            while (clothes.Count > 0)
            {
                
                if(sumClothes+clothes.Peek() < rack)
                {
                    sumClothes += clothes.Pop();
                }              
                else if (sumClothes +clothes.Peek() == rack)
                {
                    clothes.Pop();
                    countRack++;
                    sumClothes = 0;
                }
                else if (sumClothes + clothes.Peek() > rack)
                {
                    countRack++;
                    sumClothes = 0;

                }
            }
            if (sumClothes != 0)
            {
                countRack++;
                Console.WriteLine(countRack);
            }
            else
            {
                Console.WriteLine(countRack);
            }
        }
    }
}
