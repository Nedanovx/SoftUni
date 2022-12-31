using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            List<string> banned = new List<string>();
            while (input != "exam finished")
            {
                string[] inputArg = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (inputArg.Length == 2)
                {
                    string name = inputArg[0];
                    string cmd = inputArg[1];                   
                        banned.Add(name);                    
                }
                else
                {
                    string name = inputArg[0];
                    string language = inputArg[1];
                    int points = int.Parse(inputArg[2]);
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                    if (!students.ContainsKey(name))
                    {
                        students.Add(name, 0);
                        students[name] = points;                       
                    }
                    else if(students[name] < points)
                    {
                        students[name] = points;
                    }
                                       
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine("Results:");
            foreach (var student in students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                if (!banned.Contains(student.Key))
                {            
                        Console.WriteLine($"{student.Key} | {string.Join("",student.Value)}");                                      
                }
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}