using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for(int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (!students.ContainsKey(input[0]))
                {
                    students.Add(input[0], new List<decimal>());
                }
                students[input[0]].Add(decimal.Parse(input[1]));
            }
            foreach(var name in students)
            {
                Console.Write($"{name.Key} -> ");
                foreach(var grade in name.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {name.Value.Average():f2})");
            }
        }
    }
}
