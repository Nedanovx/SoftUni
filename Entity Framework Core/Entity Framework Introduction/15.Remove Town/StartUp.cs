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
            Console.WriteLine(RemoveTown(context));
            
           
        }
        public static string RemoveTown(SoftUniContext context)
        {
            var employee = context.Employees
                .Include(x => x.Address)
                .Where(x => x.Address.Town.Name == "Seattle")
                .ToList();

            foreach(var e in employee)
            {
                e.AddressId = null;
            }

            var townToDelete = context.Towns
            .Include(x => x.Addresses)
            .FirstOrDefault(x => x.Name == "Seattle");

            context.Addresses.RemoveRange(townToDelete.Addresses);
            context.Towns.Remove(townToDelete);

            context.SaveChanges();

            return $"{townToDelete.Addresses.Count} addresses in Seattle were deleted";

        }
    }
}