using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command =Console.ReadLine();
            List<Person> persons = new List<Person>();
            while (command != "End")
            {
                string[] cmdArg = command.Split();
                string name = cmdArg[0];
                string id = cmdArg[1];
                int age = int.Parse(cmdArg[2]);
                command = Console.ReadLine();
                Person person = new Person(name, id, age);
                persons.Add(person);
            }

            foreach(Person person in persons.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }

        public int Age { get; set; }
    }
}
