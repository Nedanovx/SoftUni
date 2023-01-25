using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;
            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                int sumOfPeeks = 0;
                sumOfPeeks = bombEffects.Peek() + bombCasings.Peek();
                if (sumOfPeeks != 40 && sumOfPeeks != 60 && sumOfPeeks != 120)
                {
                    int stackPeek = bombCasings.Peek();
                    bombCasings.Pop();
                    stackPeek -= 5;
                    bombCasings.Push(stackPeek);
                }
                else
                {
                    switch (sumOfPeeks)
                    {
                        case 40:
                            daturaBombs++;
                            bombCasings.Pop();
                            bombEffects.Dequeue();
                            break;
                        case 60:
                            cherryBombs++;
                            bombCasings.Pop();
                            bombEffects.Dequeue();
                            break;
                        case 120:
                            smokeDecoyBombs++;
                            bombCasings.Pop();
                            bombEffects.Dequeue();
                            break;
                    }
                }
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    {
                        Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
                        if (bombEffects.Count > 0)
                        {
                            Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
                        }
                        else
                        {
                            Console.WriteLine("empty");
                        }

                        if (bombCasings.Count > 0)
                        {
                            Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
                        }
                        else
                        {
                            Console.WriteLine("empty");
                        }
                        Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                        Console.WriteLine($"Datura Bombs: {daturaBombs}");
                        Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        return;
                    }
                }
            }
            Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            if (bombEffects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");

        }
    }
}
