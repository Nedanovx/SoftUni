using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        List<Student> students = new List<Student>();
        public Classroom(int capacity)
        {
            students = new List<Student>();
            Capacity = capacity;
        }
        public int Capacity { get; set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if(students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return $"No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Any(x => x.FirstName == firstName && x.LastName == lastName))
            {
                Student removedStudent = students.Where(x => x.FirstName == firstName && x.LastName == lastName).First();
                students.Remove(removedStudent);
                return $"Dismissed student {firstName} { lastName}";
            }
            return $"Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            if (Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");               
                foreach (Student student in students.Where(x => x.Subject == subject))
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
              return sb.ToString().TrimEnd();
            }
            
            
              return $"No students enrolled for the subject";        
        }

        public string GetStudentsCount()
        {
            return $"{students.Count}";
        }
        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.Where(x => x.FirstName == firstName && x.LastName == lastName).First();
            return student;
        }
    }
}
