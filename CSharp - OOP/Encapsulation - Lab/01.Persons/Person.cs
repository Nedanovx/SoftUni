namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
