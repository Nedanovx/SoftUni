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
            Console.WriteLine(IncreaseSalaries(context));
            
           
        }
        public static string IncreaseSalaries(SoftUniContext context)
        {
            var result = context.Employees 
                .Where(x => x.Department.Name == "Engineering" || x.Department.Name == "Tool Design" || 
                x.Department.Name == "Marketing" || x.Department.Name == "Information Services");

            foreach(var r in result)
            {
                r.Salary *= 1.12M;
            }
            context.SaveChanges();

            StringBuilder sb = new();
            foreach(var r in result.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName))
            {
                sb.AppendLine($"{r.FirstName} {r.LastName} (${r.Salary:f2})");
            }

            return sb.ToString().Trim();
        }
    }
}