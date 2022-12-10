using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ").ToArray());           
            while(songs.Count > 0)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Add")
                {
                    string currentSong = string.Join(" ", command.Skip(1));
                    if(!songs.Contains(currentSong))
                    {
                        songs.Enqueue(currentSong);
                    }
                    else
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                }
                else if(command[0] == "Show")
                {
                    Console.WriteLine($"{string.Join(", ", songs)}");
                }
                else if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
