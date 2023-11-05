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
            Console.WriteLine(GetLatestProjects(context));
            
           
        }
        public static string GetLatestProjects(SoftUniContext context)
        {
            var result = context.Projects
                .OrderByDescending(x => x.StartDate)
                .Take(10)
                .ToList()
                .OrderBy(x => x.Name);

            StringBuilder sb = new();
            foreach(var p in result)
            {
                sb.AppendLine(p.Name);
                sb.AppendLine(p.Description);
                sb.AppendLine($"{p.StartDate:M/d/yyyy h:mm:ss tt}");
            }

            return sb.ToString().Trim();
        }
    }
}