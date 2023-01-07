using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Action<int[]> add = x =>
            {
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] += 1;
                }
            };
            Action <int[]> print = x => Console.WriteLine(string.Join(" ",number));
            Action<int[]> multiplyNumbers = x =>
            {
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] *= 2;
                }
            };
            Action<int[]> subtract = x =>
            {
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] -= 1;
                }
            };
            while(command != "end")
            {
                if(command == "add")
                {
                    add(number);
                }
                else if(command == "print")
                {
                    print(number);
                }
                else if(command == "multiply")
                {
                    multiplyNumbers(number);
                }
                else if(command == "subtract")
                {
                    subtract(number);
                }
                command = Console.ReadLine();
            }
        }
    }
}
