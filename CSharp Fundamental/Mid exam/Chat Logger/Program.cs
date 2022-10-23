using System;
using System.Collections.Generic;

namespace Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] cmdArg = command.Split(' ');
                string cmdType = cmdArg[0];
                if(cmdType == "Chat")
                {
                    chat.Add(cmdArg[1]);
                }
                else if (cmdType == "Delete")
                {
                    if(chat.Contains(cmdArg[1]))
                    {
                        chat.Remove(cmdArg[1]);
                    }
                }
                else if(cmdType == "Edit")
                {
                    if (chat.Contains(cmdArg[1]))
                    {
                        
                        int index = chat.IndexOf(cmdArg[1]);
                        chat.Insert(index, cmdArg[2]);
                        chat.Remove(cmdArg[1]);
                    }
                }
                else if(cmdType == "Pin")
                {
                    if (chat.Contains(cmdArg[1]))
                    {
                        chat.Remove(cmdArg[1]);
                        chat.Add(cmdArg[1]);
                    }
                }
                else if(cmdType == "Spam")
                {
                    for(int i = 1; i < cmdArg.Length; i++)
                    {
                        chat.Add(cmdArg[i]);
                    }
                }
                command = Console.ReadLine();
            }
            foreach(string word in chat)
            {
                Console.WriteLine(word);
            }
        }
    }
}
