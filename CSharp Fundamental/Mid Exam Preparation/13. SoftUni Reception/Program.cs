using System;

namespace _13._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // на колко студенти може да съдейства един служител за 1 час
            int employe1 = int.Parse(Console.ReadLine());
            int employe2 = int.Parse(Console.ReadLine());
            int employe3 = int.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            int totalempl = employe1 + employe2 + employe3; // общо брой обслужени студенти за 1 час
            int hours = 0;
            int breakHour = 0;
            while(countStudents > 0)
            {
                countStudents -=totalempl;
                hours++;
                if(countStudents <= 0)
                {
                    break;
                }
                if(hours % 3 == 0)
                {
                    breakHour++;
                }

            }
            Console.WriteLine($"Time needed: {hours + breakHour}h.");
        }
    }
}
