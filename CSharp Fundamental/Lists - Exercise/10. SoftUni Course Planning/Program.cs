using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
             .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "course start")
            {
                string[] cmdArg = command.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmdType = cmdArg[0];
                string name = cmdArg[1];

                Operation(schedule, cmdType, name, cmdArg);
                command = Console.ReadLine();
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        private static void Operation(List<string> schedule, string cmdType, string name, string[] cmdArg)
        {
            if (cmdType == "Add")
            {
                if (!schedule.Contains(name))
                {
                    schedule.Add(name);
                }
            }
            else if (cmdType == "Insert")
            {
                int index = int.Parse(cmdArg[2]);
                if (!schedule.Contains(name))
                {
                    schedule.Insert(index, name);
                }
            }
            else if (cmdType == "Remove")
            {
                int currentIndex = schedule.IndexOf(name);
                if (schedule.Contains(name))
                {
                    if (schedule.Contains($"{name}-Exercise"))
                    {
                        schedule.RemoveAt(currentIndex + 1);
                        schedule.RemoveAt(currentIndex);
                    }
                    else
                    {
                        schedule.RemoveAt(currentIndex);
                    }
                }
            }
            else if (cmdType == "Swap")
            {
                string lesson = cmdArg[2];
                SwapLesson(schedule, name, lesson);
            }
            else if (cmdType == "Exercise")
            {               
                if (schedule.Contains(name))
                {
                    int index = schedule.IndexOf(name);

                    if (!schedule.Contains($"{name}-Exercise"))
                    {
                        schedule.Insert(index + 1, $"{name}-Exercise");
                    }                   
                }
                else
                {
                    schedule.Add(name);
                    schedule.Add($"{name}-Exercise");
                }
            }
        }
       
        static void SwapLesson(List<string> schedule, string name, string lesson)
        {
            if (schedule.Contains(name) && schedule.Contains(lesson))
            {
                if (schedule.Contains($"{name}-Exercise") && schedule.Contains($"{lesson}-Exercise"))
                {
                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == name)
                        {
                            schedule[i] = lesson;
                            schedule.Insert(i + 1, $"{lesson}-Exercise");
                            schedule.RemoveAt(i + 2);
                        }
                        else if (schedule[i] == lesson)
                        {
                            schedule[i] = name;
                            schedule.Insert(i + 1, $"{name}-Exercise");
                            schedule.RemoveAt(i + 2);
                        }
                    }
                }
                else if (schedule.Contains($"{name}-Exercise"))
                {
                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == name)
                        {
                            schedule[i] = lesson;
                            schedule.RemoveAt(i + 1);
                        }
                        else if (schedule[i] == lesson)
                        {
                            schedule[i] = name;
                            schedule.Insert(i + 1, $"{name}-Exercise");
                        }
                    }
                }
                else if (schedule.Contains($"{lesson}-Exercise"))
                {
                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == name)
                        {
                            schedule[i] = lesson;
                            schedule.Insert(i + 1, $"{lesson}-Exercise");
                        }
                        else if (schedule[i] == lesson)
                        {
                            schedule[i] = name;
                            schedule.RemoveAt(i + 1);
                        }
                    }
                }
                else if ((!schedule.Contains($"{name}-Exercise")) &&
                    (!schedule.Contains($"{lesson}-Exercise")))
                {
                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == name)
                        {
                            schedule[i] = lesson;
                        }
                        else if (schedule[i] == lesson)
                        {
                            schedule[i] = name;
                        }
                    }
                }
            }
        }

       
    }
}
