using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> person = new List<Person>();
            for(int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                person.Add(new Person(input[0], int.Parse(input[1])));
            }
            string conditionFilter = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string formatOutput = Console.ReadLine();
            Func<Person, bool> filter = GetFilter(conditionFilter, ageFilter);
            Action<Person> print = GetPrint(formatOutput);
            person = person.Where(filter).ToList();
            person.ForEach(print);
        }

        private static Action<Person> GetPrint(string formatOutput)
        {
            switch(formatOutput)
            {
                case "name age":
                    return x => Console.WriteLine($"{x.Name} - {x.Age}");
                case "name":
                    return x => Console.WriteLine(x.Name);
                case "age":
                    return x => Console.WriteLine(x.Age);
                default:
                    return null;
            }
        }

        private static Func<Person, bool> GetFilter(string conditionalFilter, int ageFilter)
        {
            if (conditionalFilter == "older")
            {
                return x => x.Age >= ageFilter;
            }
            else
            {
                return x => x.Age < ageFilter;
            }
        }
    }
}
