using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            Resources = new HashSet<Resource>();
            Homeworks = new HashSet<Homework>();
            StudentsCourses = new HashSet<StudentCourse>();
        }
        [Key]
        public int CourseId { get; set; }

        [MaxLength(80)]
        [Unicode(true)]
        public string Name { get; set; } = null!;

        [Unicode(true)]
        public string? Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<Resource> Resources { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
        public ICollection<StudentCourse> StudentsCourses { get; set; }
    }
}