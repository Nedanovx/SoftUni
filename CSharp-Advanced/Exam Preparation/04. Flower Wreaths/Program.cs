using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Flower_Wreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int missingFlowers = 0;
            int wreaths = 0;
             while(lilies.Count > 0 && roses.Count > 0)
            {
                int flowers = lilies.Peek() + roses.Peek();
                if(flowers == 15)
                {
                    lilies.Pop();
                    roses.Dequeue();
                    wreaths++;
                }
                else if(flowers > 15)
                {
                    int currentPeek = lilies.Pop();
                    currentPeek -= 2;
                    lilies.Push(currentPeek);
                }
                else if(flowers < 15)
                {
                    missingFlowers += lilies.Pop() + roses.Dequeue();
                }
            }
             if(missingFlowers > 15)
            {
                wreaths += missingFlowers / 15;
            }
             if(wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
