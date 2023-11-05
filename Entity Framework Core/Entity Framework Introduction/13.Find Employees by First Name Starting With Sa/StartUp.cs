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
            Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context));
            
           
        }
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var result = context.Employees
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.JobTitle,
                    x.Salary
                })
                .Where(x => EF.Functions.Like(x.FirstName, "sa%"))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach(var e in result)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }
            return sb.ToString().Trim();
        }
    }
}