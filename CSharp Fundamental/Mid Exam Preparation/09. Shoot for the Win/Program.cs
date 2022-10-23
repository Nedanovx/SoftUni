using System;
using System.Linq;

namespace _09._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int countShotTargets = 0;
            while(command != "End")
            {
                int index = int.Parse(command);
                if (index < 0 || index >= targets.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (index < targets.Length || index >= 0)
                {
                    if (targets[index] != -1)
                    {
                        int currenIndex = targets[index];
                        targets[index] = -1;
                        countShotTargets++;
                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] > currenIndex)
                            {
                                targets[i] -= currenIndex;
                            }
                            else if (targets[i] <= currenIndex && targets[i] != -1)
                            {
                                targets[i] += currenIndex;
                            }
                        }                      
                    }
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {countShotTargets} -> " +  string.Join(" ", targets));
        }
    }
}
