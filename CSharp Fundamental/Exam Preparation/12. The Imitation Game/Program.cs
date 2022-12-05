using System;
using System.Text;

namespace _12._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(encrypted);
            while (command != "Decode")
            {

                string[] cmdArg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if (cmdType == "Move")
                {
                    int number = int.Parse(cmdArg[1]);
                    for (int i = 0; i < number; i++)
                    {
                        sb.Append(sb[i]);

                    }
                    sb.Remove(0, number);
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index >= 0 && index <= sb.Length)
                    {
                        sb.Insert(index, cmdArg[2]);
                    }
                    else if (index < 0)
                    {
                        break;
                    }
                   
                }
                else if (cmdType == "ChangeAll")
                {
                    if (encrypted.Contains(cmdArg[1]))
                    {
                        sb = sb.Replace(cmdArg[1], cmdArg[2]);

                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {sb}");
        }
    }
}
