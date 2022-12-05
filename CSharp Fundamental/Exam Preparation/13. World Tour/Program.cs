using System;

namespace _13._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string worldTour = Console.ReadLine();
            string command = Console.ReadLine();
            while(command != "Travel")
            {
                string[] cmdArg = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if(cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdArg[1]);
                    string text = cmdArg[2];
                    if(index >= 0 && index < worldTour.Length)
                    {
                        worldTour = worldTour.Insert(index, text);
                    }
                    Console.WriteLine(worldTour);
                }
                else if(cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    if(startIndex >= 0 && startIndex < worldTour.Length && endIndex >= 0 && endIndex < worldTour.Length)
                    {
                        worldTour = worldTour.Remove(startIndex, endIndex-startIndex+1);
                    }
                    Console.WriteLine(worldTour);
                }
                else if(cmdType == "Switch")
                {
                    string oldString = cmdArg[1];
                    string newString = cmdArg[2];
                    if(worldTour.Contains(oldString))
                    {
                       worldTour = worldTour.Replace(oldString, newString);
                    }
                    Console.WriteLine(worldTour);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {worldTour}");
        }
    }
}
