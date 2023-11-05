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
            Console.WriteLine(GetEmployee147(context));
            
           
        }
        public static string GetEmployee147(SoftUniContext context)
        {
            var result = context.Employees
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Select(x => new
                {
                    x.EmployeeId,
                    x.FirstName,
                    x.LastName,
                    x.JobTitle,
                    project = x.EmployeesProjects
                    .Select(x => new
                    {
                        x.Project.Name
                    }).ToList()
                })
                .Where(e => e.EmployeeId == 147) .ToList();

            StringBuilder sb = new();
            foreach(var r in result)
            {
                sb.AppendLine($"{r.FirstName} {r.LastName} - {r.JobTitle}");
                if(r.project.Any())
                {
                    foreach(var p in r.project.OrderBy(x=>x.Name))
                    {
                        sb.AppendLine($"{p.Name}");
                    }
                }
            }
            return sb.ToString().Trim();
        }
    }
}