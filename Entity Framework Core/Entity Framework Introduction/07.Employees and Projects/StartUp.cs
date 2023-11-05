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
            Console.WriteLine(GetEmployeesInPeriod(context));
            
           
        }
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var result = context.Employees
                .Take(10)
                .Include(e => e.Manager)
                .Include(e => e.EmployeesProjects)
                .ToList();

            StringBuilder sb = new();
            foreach (var e in result)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.Manager.FirstName} {e.Manager.LastName}");
                if(e.EmployeesProjects.Count > 0)
                {
                    var project = context.EmployeesProjects
                        .Select(ep => new
                        {
                            ep.EmployeeId,
                            ep.Project.Name,
                            ep.Project.StartDate,
                            ep.Project.EndDate
                        })
                        .Where(ep => ep.EmployeeId == e.EmployeeId)
                        .ToList();
                    foreach(var p in project.Where(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003))
                    {
                        if(p.EndDate == null)
                        {
                            string endDate = "not finished";
                            sb.AppendLine($"--{p.Name} - {p.StartDate.ToString("M/d/yyy h:mm:ss tt")} - {endDate}");
                        }
                        else
                        {
                            sb.AppendLine($"--{p.Name} - {p.StartDate:M/d/yyy h:mm:ss tt} - {p.EndDate:M/d/yyy h:mm:ss tt}");
                        }
                    }
                }
            }
                
            return sb.ToString().Trim();
        }
    }
}