using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputInfo = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();
            for (int i = 0; i < inputInfo.Length; i++)
            {
                string[] wordAndDefinition = inputInfo[i].Split(':', StringSplitOptions.RemoveEmptyEntries);
                string word = wordAndDefinition[0];
                string definition = wordAndDefinition[1];
                if (!notebook.ContainsKey(word))
                {
                    notebook.Add(word, new List<string>());
                    notebook[word].Add(definition);
                }
                else
                {
                    notebook[word].Add(definition);
                }
            }
            string teacher = Console.ReadLine();
            string[] teacherWord = teacher.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            string command = Console.ReadLine();
            if (command == "Hand Over")
            {
                foreach (var word in notebook)
                {
                    Console.Write($"{word.Key} ");
                }
            }
            else if (command == "Test")
            {
                for (int i = 0; i < teacherWord.Length; i++)
                {

                    string word = teacherWord[i];
                    foreach (var val in notebook.Keys)
                    {
                        if(val.Equals(word))
                        {
                            Console.WriteLine($"{word}:");
                            
                            foreach(var val2 in notebook[val])
                            {
                                Console.WriteLine($" -{string.Join(", ", val2).Trim()}");
                            }
                        }                                                                                              
                    }

                }

            }
        }
    }
}
