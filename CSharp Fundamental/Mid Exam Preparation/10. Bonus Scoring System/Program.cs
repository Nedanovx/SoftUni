using System;

namespace _10._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            int studentAttendances = 0;
            double maxBonus = 0;
            //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus}
            for (int i = 0; i < numberOfStudents; i++)
            {
                 int attendance = int.Parse(Console.ReadLine());
                double totalBonus = ((attendance * 1.0 / numberOfLectures) * (5 + additionalBonus));
                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    studentAttendances = attendance;
                }
            }    
            
                
                Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
                Console.WriteLine($"The student has attended {studentAttendances} lectures.");                      
        }
    }
}
