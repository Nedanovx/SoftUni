using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            Homeworks = new HashSet<Homework>();
            StudentsCourses = new HashSet<StudentCourse>();
        }

        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        [Unicode(true)]
        public string Name { get; set; } = null!;

        [StringLength(10)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public ICollection<Homework> Homeworks { get; set; }
        public ICollection<StudentCourse> StudentsCourses { get; set; }
    }
}
