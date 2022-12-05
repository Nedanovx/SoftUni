using System;
using System.Linq;
using System.Text;

namespace _04._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();
            
            while(command != "Done")
            {
                string[] cmdArg = command.Split(' ');
                string cmdType = cmdArg[0];
                if(cmdType == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if(i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if(cmdType == "Cut")
                {
                    int index = int.Parse(cmdArg[1]);
                    int length = int.Parse(cmdArg[2]);
                    int substringLength = index + length;
                    if (substringLength <= password.Length)
                    {
                       password = password.Remove(index, length);
                        Console.WriteLine(password);
                    }
                }
                else if(cmdType == "Substitute")
                {
                    string substring = cmdArg[1];
                    string substitute = cmdArg[2];
                    if(!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                       password =  password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
