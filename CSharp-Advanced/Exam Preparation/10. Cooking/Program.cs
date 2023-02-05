using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _10._Cooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countBread = 0;
            int countCake = 0;
            int countPastry = 0;
            int countFruitPie = 0;
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> food = new Dictionary<string, int>()
            {
             {"Bread",0},
             {"Cake", 0},
            {"Pastry", 0},
            {"Fruit Pie", 0}
            };
            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int currentLiquids = liquids.Peek();
                int currentIngredients = ingredients.Peek();
                int sum = currentLiquids + currentIngredients;
                switch (sum)
                {
                    case 25:
                        {
                            countBread++;
                            liquids.Dequeue();
                            ingredients.Pop();
                            food["Bread"] = countBread;
                            break;
                        }
                    case 50:
                        {
                            countCake++;
                            liquids.Dequeue();
                            ingredients.Pop();
                            food["Cake"] = countCake;
                            break;
                        }
                    case 75:
                        {
                            countPastry++;
                            liquids.Dequeue();
                            ingredients.Pop();
                            food["Pastry"] = countPastry;
                            break;
                        }
                    case 100:
                        {
                            countFruitPie++;
                            liquids.Dequeue();
                            ingredients.Pop();
                            food["Fruit Pie"] = countFruitPie;
                            break;
                        }
                    default:
                        liquids.Dequeue();
                        currentIngredients = ingredients.Pop();
                        currentIngredients += 3;
                        ingredients.Push(currentIngredients);
                        break;
                }
            }
            if (countBread > 0 && countCake > 0 && countFruitPie > 0 && countPastry > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count > 0)
            {
                Console.Write($"Liquids left: {String.Join(", ", liquids)}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (ingredients.Count > 0)
            {
                Console.Write($"Ingredients left: {String.Join(", ", ingredients)}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var kvp in food.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
