using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> task = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> tread = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int value = int.Parse(Console.ReadLine());
            while(tread.Count > 0)
            {
                int currentTask = task.Peek();
                int currentTread = tread.Peek();
                if(currentTask == value)
                {                   
                        Console.WriteLine($"Thread with value {currentTread} killed task {value}");
                        Console.WriteLine(String.Join(" ",tread));
                        return;                    
                }
                else if(currentTread >= currentTask)
                {
                    task.Pop();
                    tread.Dequeue();
                }
                else
                {
                    tread.Dequeue();
                }
            }
        }
    }
}
