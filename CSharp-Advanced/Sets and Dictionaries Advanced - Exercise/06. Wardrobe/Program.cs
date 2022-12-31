using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> wardrobe = new Dictionary<string,Dictionary<string,int>>();
            for(int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string,int>());
                }
                for(int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j],0);
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }
            string[] findClothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach(var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach(var clothesInColor in kvp.Value)
                {
                    if (kvp.Key == findClothes[0] && clothesInColor.Key == findClothes[1])
                    {
                        Console.WriteLine($"* {clothesInColor.Key} - {clothesInColor.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothesInColor.Key} - {clothesInColor.Value}");
                    }
                }
            }
        }
        
    }
}
