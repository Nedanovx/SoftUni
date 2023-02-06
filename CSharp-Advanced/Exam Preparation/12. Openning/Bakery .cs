using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        List<Employee> employees = new List<Employee>();

        public Bakery(string name, int capacity)
        {
            employees = new List<Employee>();
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void Add(Employee employee)
        {
            if(employees.Count < Capacity)
            {
                employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            if(employees.Any(x => x.Name == name))
            {
                Employee employeeToRemove = employees.FirstOrDefault(x => x.Name == name);
                employees.Remove(employeeToRemove);
                return true;
            }
            return false;
        }

        public Employee GetOldestEmployee()
        {
            Employee oldestEmployee = employees.OrderBy(x => x.Age).First();
            return oldestEmployee;
        }

        public Employee GetEmployee(string name)
        {
            if (employees.Any(x => x.Name == name))
            {
                Employee currentEmployee = employees.Where(x => x.Name == name).FirstOrDefault();
                return currentEmployee;
            }
            return null;
        }
        public int Count => employees.Count;

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach(Employee employee in employees)
            {
                sb.AppendLine(employee.ToString());
            }
            return sb.ToString();
        }
    }
}
