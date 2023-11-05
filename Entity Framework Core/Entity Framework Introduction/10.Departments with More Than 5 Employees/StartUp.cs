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
            Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context));
            
           
        }
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var result = context.Departments
                .Include(x => x.Employees)
                .Where(x => x.Employees.Count > 5)
                .OrderBy(x => x.Employees.Count)
                .ThenBy(x => x.Name)
                .ToList();

            StringBuilder sb = new();
            foreach(var e in result)
            {
                sb.AppendLine($"{e.Name} - {e.Manager.FirstName} {e.Manager.LastName}");
                foreach(var f in e.Employees.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName))
                {
                    sb.AppendLine($"{f.FirstName} {f.LastName} - {f.JobTitle}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}