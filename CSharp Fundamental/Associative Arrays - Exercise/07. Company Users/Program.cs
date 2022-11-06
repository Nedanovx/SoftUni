using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while(input != "End")
            {
                string[] cmdArg = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = cmdArg[0];
                string id = cmdArg[1];
                if(!companyUsers.ContainsKey(company))
                {
                    companyUsers[company] = new List<string>();                  
                    companyUsers[company].Add(id);                  
                }
                else
                {
                    if (!companyUsers[company].Contains(id))
                    {
                        companyUsers[company].Add(id);
                    }
                   
                }
                input = Console.ReadLine();
            }
            foreach(var key in companyUsers)
            {
                Console.WriteLine(key.Key);
                foreach(var idNumber in key.Value)
                {
                    Console.WriteLine($"-- {idNumber}");
                }
            }
        }
    }
}
