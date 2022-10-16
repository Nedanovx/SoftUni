using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distanceToPokemon = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int sum = 0;


            while (distanceToPokemon.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < distanceToPokemon.Count)
                {                 
                    int currentNumber = distanceToPokemon[index];
                    distanceToPokemon.RemoveAt(index);
                    sum+= currentNumber;

                    ChangeOtherValues(distanceToPokemon, currentNumber);
                }
                else if (index < 0)
                {
                    int currentNumber = distanceToPokemon[0];  
                    sum += currentNumber;
                    distanceToPokemon.RemoveAt(0);                   
                    distanceToPokemon.Insert(0, distanceToPokemon[distanceToPokemon.Count-1]);
                    ChangeOtherValues(distanceToPokemon, currentNumber);                   
                }
                else if (index > distanceToPokemon.Count - 1)
                {
                    int currentNumber = distanceToPokemon[distanceToPokemon.Count - 1];
                    sum += currentNumber;
                    distanceToPokemon.RemoveAt(distanceToPokemon.Count - 1);                   
                    distanceToPokemon.Add(distanceToPokemon[0]);
                    ChangeOtherValues(distanceToPokemon, currentNumber);
                    
                }
            }
            Console.WriteLine(sum);
        }

        private static void ChangeOtherValues(List<int> distanceToPokemon, int currentNumber)
        {
            for (int i = 0; i < distanceToPokemon.Count; i++)
            {

                if (distanceToPokemon[i] <= currentNumber)
                {
                    distanceToPokemon[i] += currentNumber;
                }
                else
                {
                    distanceToPokemon[i] -= currentNumber;
                }
            }
        }
    }
}