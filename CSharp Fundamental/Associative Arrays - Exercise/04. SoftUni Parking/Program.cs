using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                string userName = cmdArg[1];
                if (cmdType == "register")
                {
                    string numberPLate = cmdArg[2];
                    if (!register.ContainsKey(userName))
                    {
                        register.Add(userName, numberPLate);
                        Console.WriteLine($"{userName} registered {numberPLate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[userName]}");
                    }
                }
                else if (cmdType == "unregister")
                {
                    if (register.ContainsKey(userName))
                    {
                        register.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }

            }
            foreach (var plateNumber in register)
            {
                Console.WriteLine($"{plateNumber.Key} => {plateNumber.Value}");
            }
        }
    }
}
