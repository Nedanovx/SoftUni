using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        private readonly StudentRepository students;
        private readonly UniversityRepository universities;
        private readonly SubjectRepository subjects;
        public Controller()
        {
            this.students = new StudentRepository();
            this.universities = new UniversityRepository();
            this.subjects = new SubjectRepository();
        }
        public string AddStudent(string firstName, string lastName)
        {
            IStudent student = this.students.FindByName($"{firstName} {lastName}");
            if (student != null)
            {
                return string.Format(OutputMessages.AlreadyAddedStudent, firstName, lastName);
            }
            student = new Student(students.Models.Count + 1, firstName, lastName);
            this.students.AddModel(student);
            return string.Format(OutputMessages.StudentAddedSuccessfully, firstName, lastName, this.students.GetType().Name);
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            if(subjectType != "TechnicalSubject" && subjectType != "EconomicalSubject" && subjectType != "HumanitySubject")
            {
                return string.Format(OutputMessages.SubjectTypeNotSupported, subjectType);
            }
            
            if(this.subjects.FindByName(subjectName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedSubject, subjectName);
            }

            ISubject subject = null;
            switch (subjectType)
            {
                case "TechnicalSubject":
                    subject = new TechnicalSubject(this.subjects.Models.Count + 1, subjectName);
                    break;
                case "EconomicalSubject":
                    subject = new EconomicalSubject(this.subjects.Models.Count + 1, subjectName);
                    break ;
                case "HumanitySubject":
                    subject = new HumanitySubject(this.subjects.Models.Count + 1, subjectName);
                    break;
            }

            subjects.AddModel(subject);
            return string.Format(OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, this.subjects.GetType().Name);
            
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if(this.universities.FindByName(universityName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedUniversity,universityName);
            }
            List<int> subjectsId = requiredSubjects.Select(x => subjects.FindByName(x).Id).ToList();
            IUniversity university = new University(this.universities.Models.Count + 1, universityName, category, capacity, subjectsId);
            this.universities.AddModel(university);
            return string.Format(OutputMessages.UniversityAddedSuccessfully, universityName, this.universities.GetType().Name);
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            IStudent student = this.students.FindByName(studentName);
            if(student == null)
            {
                var names = studentName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                return string.Format(OutputMessages.StudentNotRegitered, names[0], names[1]);
            }
            IUniversity university = this.universities.FindByName(universityName);
            if(university == null)
            {
                return string.Format(OutputMessages.UniversityNotRegitered, universityName);
            }

            foreach(var subject in university.RequiredSubjects)
            {
                if(!student.CoveredExams.Contains(subject))
                {
                    return string.Format(OutputMessages.StudentHasToCoverExams, studentName, universityName);
                }
            }
            if(student.University != null && student.University.Name == universityName)
            {
                return string.Format(OutputMessages.StudentAlreadyJoined, student.FirstName, student.LastName, universityName);
            }
            student.JoinUniversity(university);
            return string.Format(OutputMessages.StudentSuccessfullyJoined, student.FirstName, student.LastName, universityName);
        }

        public string TakeExam(int studentId, int subjectId)
        {
            IStudent student = this.students.FindById(studentId);
            if (student == null)
            {
                return string.Format(OutputMessages.InvalidStudentId);
            }
            ISubject subject = this.subjects.FindById(subjectId);
            if (subject == null)
            {
                return string.Format(OutputMessages.InvalidSubjectId);
            }

            if(student.CoveredExams.Contains(subjectId))
            {
                return String.Format(OutputMessages.StudentAlreadyCoveredThatExam, student.FirstName, student.LastName, subject.Name);
            }

            student.CoverExam(subject);
            return string.Format(OutputMessages.StudentSuccessfullyCoveredExam, student.FirstName, student.LastName, subject.Name);
        }

        public string UniversityReport(int universityId)
        {
            var university = this.universities.FindById(universityId);
            StringBuilder sb = new StringBuilder();
            int count = this.students.Models.Where(x => x.University == university).Count();
            sb.AppendLine($"*** {university.Name} ***");
            sb.AppendLine($"Profile: {university.Category}");
            sb.AppendLine($"Students admitted: {count}");
            sb.AppendLine($"University vacancy: {university.Capacity - count}");
            return sb.ToString().TrimEnd();
        }
    }
}
