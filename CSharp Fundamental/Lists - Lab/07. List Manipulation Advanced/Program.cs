using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            bool isChecked = false;
            while (input != "end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];
                if (command == "Add")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAt(value);
                }
                else if (command == "Insert")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, value);
                }
                else if (command == "Contains")
                {
                    int value = int.Parse(inputParams[1]);
                    if (numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = inputParams[1];
                    int value = int.Parse(inputParams[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x < value)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x <= value)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x > value)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x >= value)));
                    }
                }
                input = Console.ReadLine();
            }
            if (isChecked)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
