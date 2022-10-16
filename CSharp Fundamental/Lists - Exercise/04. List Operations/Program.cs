using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if (cmdType == "Add")
                {
                    int value = int.Parse(cmdArg[1]);
                    numbers.Add(value);
                }
                else if (cmdType == "Insert")
                {
                    int value = int.Parse(cmdArg[1]);
                    int index = int.Parse(cmdArg[2]);
                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.Insert(index, value);
                    }
                }
                else if (cmdType == "Remove")
                {
                    int index = int.Parse(cmdArg[1]);

                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (cmdType == "Shift")
                {
                    string direction = cmdArg[1];
                    int count = int.Parse(cmdArg[2]);
                    if (direction == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else
                    {
                        ShiftListRight(numbers, count);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
        static bool IsIndexInvalid(List<int> numbers, int index)

           => index < 0 || index >= numbers.Count;

        static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }
        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}