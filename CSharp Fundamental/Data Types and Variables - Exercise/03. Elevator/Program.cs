using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volumeOfElevator = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int courses = volumeOfElevator / people;
            if (volumeOfElevator % people != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
