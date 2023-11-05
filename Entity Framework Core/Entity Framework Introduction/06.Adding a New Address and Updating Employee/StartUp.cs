using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(AddNewAddressToEmployee(context));
            
           
        }
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            var employee = context.Employees.FirstOrDefault(x => x.LastName == "Nakov");

            employee.Address = address;
            context.SaveChanges();

            var result = context.Employees
                .OrderByDescending(x => x.AddressId)
                .Select(e => new
                {
                    e.Address
                }).Take(10).ToList();

            StringBuilder sb = new StringBuilder();

            foreach(var item in result)
            {
                sb.AppendLine(item.Address.AddressText);
            }
            return sb.ToString().TrimEnd();
        }
    }
}