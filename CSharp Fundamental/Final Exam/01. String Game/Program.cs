using System;

namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if (cmdType == "Change")
                {
                    char oldChar = char.Parse(cmdArg[1]);
                    char newChar = char.Parse(cmdArg[2]);
                    foreach (var symbol in text)
                    {
                        if (text.Contains(oldChar))
                        {
                            text = text.Replace(oldChar, newChar);
                        }
                    }
                    Console.WriteLine(text);
                }
                else if (cmdType == "Includes")
                {
                    string substring = cmdArg[1];
                    if (text.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmdType == "End")
                {
                    string substring = cmdArg[1];
                    if(text.EndsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(cmdType == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if(cmdType == "FindIndex")
                {
                    char symbol = char.Parse(cmdArg[1]);                   
                    Console.WriteLine(text.IndexOf(symbol));
                }
                else if(cmdType == "Cut")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int length = int.Parse(cmdArg[2]);
                    string cutString = text.Substring(startIndex, length);
                    text.Remove(startIndex, length);
                    Console.WriteLine(cutString);
                }
                command = Console.ReadLine();
            }
        }
    }
}
