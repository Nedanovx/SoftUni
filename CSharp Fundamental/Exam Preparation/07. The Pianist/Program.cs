using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> pieces = new Dictionary<string, string>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = inputArray[0];
                string composerAndKey = $"{inputArray[1]}:{inputArray[2]}";
                pieces.Add(piece, composerAndKey);
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {        
                string[] cmdArg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if (cmdType == "Add")
                {
                    string piece = cmdArg[1];
                    string composer = cmdArg[2];
                    string key = cmdArg[3];
                    if (!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, $"{composer}:{key}");
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (cmdType == "Remove")
                {
                    string piece = cmdArg[1];
                    if (!pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                }
                else if (cmdType == "ChangeKey")
                {
                    string piece = cmdArg[1];
                    string newKey = cmdArg[2];
                    if (pieces.ContainsKey(piece))
                    {
                        string[] key = pieces[piece].Split(":");
                        key[1] = newKey;
                        pieces[piece] = string.Join(":", key);
                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }
                command = Console.ReadLine();
            }
            foreach(var kvp in pieces)
            {
                string[] composerKey = kvp.Value.Split(':');
                Console.WriteLine($"{kvp.Key} -> Composer: {composerKey[0]}, Key: {composerKey[1]}");
            }
        }
    }
}
