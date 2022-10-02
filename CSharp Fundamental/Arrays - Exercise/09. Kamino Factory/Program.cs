using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] dna = new int[length];
            string input = Console.ReadLine();
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStartIndex =-1;
            int dnaSamples =0;
            int samples = 0;
            while (input != "Clone them!")
            {
                samples++;
                int[] currentDna = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentCount = 0;
                int currentStartIndex = 0;
                int currentEndIndex = 0;
                int currenDnaSum = 0;
                bool isCurrentDnaBetter = false;

                int count = 0;
                for (int i = 0; i < currentDna.Length; i++)
                {
                    if (currentDna[i] != 1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;
                    if (count > currentCount)
                    {
                        currentCount = count;
                        currentEndIndex = i;
                    }
                }
                currentStartIndex = currentEndIndex - currentCount + 1;
                currenDnaSum = currentDna.Sum();
                if (currentCount > dnaCount) 
                { 
                    isCurrentDnaBetter = true;
                }
                else if (currentCount == dnaCount)
                {
                    if (currentStartIndex < dnaStartIndex)
                    {
                        isCurrentDnaBetter = true;
                    }
                    else if( currentStartIndex == dnaStartIndex)
                    {
                        if(currenDnaSum > dnaSum)
                        {
                            isCurrentDnaBetter = true;
                        }
                    }
                }
                if (isCurrentDnaBetter)
                {
                    dna = currentDna;
                    dnaStartIndex = currentStartIndex;
                    dnaCount = currentCount;
                    dnaSum = currenDnaSum;
                    dnaSamples = samples;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(String.Join(" ", dna));
        }
    }
}
