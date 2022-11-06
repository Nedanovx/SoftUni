using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] cmdArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArg[0];
                string studentName = cmdArg[1];
                if(!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentName);

                input = Console.ReadLine();
            }
            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (string name in kvp.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
