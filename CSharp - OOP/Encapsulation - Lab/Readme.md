# 01. Sort People by Name and Age
NOTE: You need a public StartUp class with the namespace PersonsInfo.

Create a class Person, which should have public properties with private setters for:
- FirstName: string
- LastName: string
- Age: int
- ToString(): string - override

You should be able to use the class like this:
```ruby
public static void Main()

{

var lines = int.Parse(Console.ReadLine());

var persons = new List<Person>();

for (int i = 0; i < lines; i++)

{

var cmdArgs = Console.ReadLine().Split();

var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));

persons.Add(person);

}

persons.OrderBy(p => p.FirstName)

.ThenBy(p => p.Age)

.ToList()

.ForEach(p => Console.WriteLine(p.ToString()));

}
```

**Examples:**
Input|
---|
5<br/>Brandi Anderson 65<br/>Andrew Williams 57<br/>Newton Holland 27<br/>Andrew Clark 44<br/>Brandi Scott 35|
Output|
Andrew Clark is 44 years old.<br/>Andrew Williams is 57 years old. <br/>Brandi Scott is 35 years old.<br/> Brandi Anderson is 65 years old.<br/> Newton Holland is 27 years old.

# 02. Salary Increase
NOTE: You need a public StartUp class with the namespace PersonsInfo. Refactor the project from the last task.

Create objects of the class Person. Read their name, age, and salary from the console. Read the percentage of the bonus to every Person's salary. 
People younger than 30 get half the increase. Expand Person from the previous task.

New properties and methods:
- Salary: decimal
- IncreaseSalary(decimal percentage)

You should be able to use the class like this
```ruby
var lines = int.Parse(Console.ReadLine());

var persons = new List<Person>();

for (int i = 0; i < lines; i++)

{

var cmdArgs = Console.ReadLine().Split();

var person = new Person(cmdArgs[0],

cmdArgs[1],

int.Parse(cmdArgs[2]),

decimal.Parse(cmdArgs[3]));

persons.Add(person);

}

var parcentage = decimal.Parse(Console.ReadLine());

persons.ForEach(p => p.IncreaseSalary(parcentage));

persons.ForEach(p => Console.WriteLine(p.ToString()));
```
**Examples:**
Input|
---|
5<br/>Andrew Williams 65 2200<br/>Newton Holland 57 3333<br/>Rachelle Nelson 27 600<br/>Brandi Scott 44 666.66<br/>George Miller 35 559.4<br/>20|
Output|
Andrew Williams receives 2640.00 leva.<br/> Newton Holland receives 3999.60 leva.<br/> Rachelle Nelson receives 660.00 leva.<br/> Brandi Scott receives 799.99 leva.<br/> George Miller receives 671.28 leva.

# 03. Validation of Data
NOTE: You need a public StartUp class with the namespace PersonsInfo. The skeleton from the previous task could be used.

Expand Person with proper validation for every field:
- Name must be at least 3 symbols
- Age must not be zero or negative
- Salary can't be less than 460 (decimal) If some of the properties are NOT valid throw ArgumentExeption with the following messages:
- "Age cannot be zero or a negative integer!"
- "First name cannot contain fewer than 3 symbols!"
- "Last name cannot contain fewer than 3 symbols!"
- "Salary cannot be less than 650 leva!"

**Examples:**

Input|
---|
5<br/>Andrew Williams -6 2200<br/>B Gomez 57 3333<br/>Carolina Richards 27 670<br/>Gilbert H 44 666.66<br/>Joshua Anderson 35 300<br/>20
Output|
Age cannot be zero or a negative integer!<br/> First name cannot contain fewer than 3 symbols!<br/> Last name cannot contain fewer than 3 symbols!<br/> Salary cannot be less than 650 leva!<br/> Carolina Richards receives 737.00 leva.

# 04. First and Reserve Team
NOTE: You need a public StartUp class with the namespace PersonsInfo. The skeleton from the previous task could be used.

Create a Team class. Add to this team all of the people you have received. Those who are younger than 40 go to the first team, others go to the reserve team. At the end print the sizes of the first and the reserved team.

The class should have private fields for:
- name: string
- firstTeam: List<Person>
- reserveTeam: List<Person>

The class should have constructors:
- Team(string name)

The class should also have public properties for:
- FirstTeam: List<Person> (read-only!)
- ReserveTeam: List<Person> (read-only!)

And a method for adding players:
- AddPlayer(Person person): void

You should be able to use the class like this:
```ruby
  Team team = new Team("SoftUni");

foreach (Person person in persons)

{

team.AddPlayer(person);

}
  ```
  **Examples:**
  
  Input|
  ---|
  5<br/>Andrew Williams 20 2200<br/>Newton Holland 57 3333<br/>Rachelle Nelson 27 600<br/>Grigor Dimitrov 25 666.66<br/>Brandi Scott 35 555
  Output|
  First team has 4 players.<br/> Reserve team has 1 players.




