using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        string name;
        int age;


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
      

        public string Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } set { age = value; } }
    }
}
