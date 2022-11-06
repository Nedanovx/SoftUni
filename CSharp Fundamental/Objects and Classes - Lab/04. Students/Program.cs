using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] personInfo = input.Split();
                string firstName = personInfo[0];
                string lastName = personInfo[1];
                int age = int.Parse(personInfo[2]);
                string town = personInfo[3];
                
                Student student = new Student(firstName, lastName, age, town);
                students.Add(student);
                input = Console.ReadLine();
            }
            string desiredTown = Console.ReadLine();
            foreach (Student currentStudent in students)
            {
                if (currentStudent.Town == desiredTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }
    }
}
