using System;
using System.Text;

namespace _08._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(activationKey);
            while (command != "Generate")
            {
                string[] cmdArg = command.Split(">>>");
                string cmdType = cmdArg[0];
                if (cmdType == "Contains")
                {
                    string substring = cmdArg[1];
                    if (sb.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{sb} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if(cmdType == "Flip")
                {
                    string flip = cmdArg[1];
                    int startIndex = int.Parse(cmdArg[2]);
                    int lastIndex = int.Parse(cmdArg[3]);
                    string subString = sb.ToString().Substring(startIndex, lastIndex-startIndex);
                    
                    if(flip == "Upper")
                    {
                        subString = subString.ToUpper();
                    }
                    else if(flip == "Lower")
                    {
                        subString = subString.ToLower();
                    }
                    sb.Remove(startIndex, lastIndex-startIndex);
                    sb.Insert(startIndex, subString);
                    Console.WriteLine(sb);
                }
                else if(cmdType == "Slice")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int lastIndex = int.Parse(cmdArg[2]);
                    sb.Remove(startIndex, lastIndex - startIndex);
                    Console.WriteLine(sb);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
