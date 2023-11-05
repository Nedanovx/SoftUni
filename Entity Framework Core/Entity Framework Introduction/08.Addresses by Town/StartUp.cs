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
            Console.WriteLine(GetAddressesByTown(context));
            
           
        }
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var result = context.Addresses 
                .Include(x => x.Employees)
                .Include(x => x.Town)
                .OrderByDescending(x => x.Employees.Count)
                .ThenBy(x => x.Town.Name)
                .ThenBy(x => x.AddressText)
                .Take(10)
                .ToList();

            StringBuilder sb = new();
            foreach(var address in result)
            {
                sb.AppendLine($"{address.AddressText}, {address.Town.Name} - {address.Employees.Count} employees");
            }

            return sb.ToString().Trim();
        }
    }
}