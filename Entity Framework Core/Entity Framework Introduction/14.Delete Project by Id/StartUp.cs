using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(DeleteProjectById(context));
            
           
        }
        public static string DeleteProjectById(SoftUniContext context)
        {
            var projectToDelete = context.Projects.Find(2);
            context.EmployeesProjects.RemoveRange(context.EmployeesProjects.Where(x => x.Project == projectToDelete));
            context.Projects.Remove(projectToDelete);
            context.SaveChanges();

            StringBuilder sb = new();

            var projects = context.Projects.Take(10);
            foreach(var p in projects)
            {
                sb.AppendLine(p.Name);
            }
            return sb.ToString().Trim();
        }
    }
}