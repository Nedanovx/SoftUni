# 1. Define an Interface IPerson
NOTE: You need a public StartUp class with the namespace PersonInfo.

Define an interface IPerson with properties for Name and Age. Define a class Citizen that implements IPerson and has two properties string name and an int age. 
The Citizen should accept name and age upon initialization.

Try to create a new Person like this:
```ruby
string name = Console.ReadLine();

int age = int.Parse(Console.ReadLine());

IPerson person = new Citizen(name, age);

Console.WriteLine(person.Name);

Console.WriteLine(person.Age);
```

**Example:**

Input|Output
---|---
Peter|Peter
25|25

# 2. Multiple Implementation
NOTE: You need a public StartUp class with the namespace PersonInfo.

Using the code from the previous task, define an interface IIdentifiable with a string property Id and an interface IBirthable with a string property 
Birthdate and implement them in the Citizen class. Rewrite the Citizen constructor to accept the new parameters.

Test your class like this:
```ruby
string name = Console.ReadLine();

int age = int.Parse(Console.ReadLine());

string id = Console.ReadLine();

string birthdate = Console.ReadLine();

IIdentifiable identifiable = new Citizen(name, age,id, birthdate);

IBirthable birthable = new Citizen(name, age, id, birthdate);

Console.WriteLine(identifiable.Id);

Console.WriteLine(birthable.Birthdate);
```

**Example:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Peter<br/>25<br/>9105152287<br/>15/05/1991 </td>
			<td>9105152287<br/>15/05/1991<br/><br/>&nbsp; </td>
		</tr>
	</tbody>
</table>

# 3. Telephony
You have a small business - manufacturing phones and to run your business you need to create phone software.<br/>
The software should support two main phone models with the following functionality:
- Smartphone:
  - Can calling other phones.
  - Can browsing in the world wide web.
- Stationary phone:
  - Can only call other phones.

You should start the project by implementing two classes:
- The Smartphone can call other phones and browse the world wide web.
- The StationaryPhone can only call other phones.

You should also implement interfaces for each class with the appropriate methods.

**Input**

The input comes from the console. It will hold two lines:
- The First line consists of phone numbers: a string, separated by spaces.
- The Second line consists of websites: a string, separated by spaces.

**Output**

1. First, call all valid numbers in the order of input:
  - If there is a character different from a digit in a number, print: "Invalid number!" and continue with the next number.
  - If the number is 10 digits long, you are making a call from your smartphone and print: "Calling... {number}"
  - If the number is 7 digits long, you are making a call from your stationary phone and print: " Dialing... {number}"

2. Next, browser all valid websites in the order of input:
  - If there is a number in the input of the URLs, print: "Invalid URL!" and continue with the next URLs.
  - If the URL is valid, print on the console the website in the format: "Browsing: {site}!"

**Constraints**
- Each site's URL should consist only of letters and symbols (No digits are allowed in the URL address).
- The phone numbers will always be 7 or 10 digits long.

**Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>0882134215 0882134333 0899213421 0558123 3333123<br/>http://softuni.bg http://youtube.com http://www.g00gle.com<br/><br/><br/><br/><br/><br/>&nbsp; </td>
			<td>Calling... 0882134215<br/> Calling... 0882134333<br/> Calling... 0899213421<br/> Dialing... 0558123<br/> Dialing... 3333123<br/> Browsing: http://softuni.bg!<br/> Browsing: http://youtube.com!<br/> Invalid URL! </td>
		</tr>
	</tbody>
</table>

# 4. Border Control
It’s the future, you’re the ruler of a totalitarian dystopian society inhabited by citizens and robots, since you’re afraid of rebellions you decide to implement strict control of who enters your city. Your soldiers check the Ids of everyone who enters and leaves.

You will receive an unknown amount of lines from the console until the command "End" is received, on each line, <br/>
there will be a piece of information for either a citizen or a robot who tries to enter your city in the format:

**"{name} {age} {id}" for citizens and "{model} {id}" for robots. **

After the "End" command on the next line, you will receive a single number representing the last digits of fake ids, all citizens or robots whose Id ends with the specified digits must be detained.

The output of your program should consist of all detained Ids each on a separate line in the order of input.

**Input**

The input comes from the console. Every commands’ parameters before the command "End" will be separated by a single space.

**Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Peter 22 9010101122<br/>MK-13 558833251<br/>MK-12 33283122<br/>End<br/>122 </td>
			<td>9010101122<br/> 33283122<br/><br/> <br/>&nbsp;</td>
		</tr>
		<tr>
			<td>Teo 31 7801211340<br/>Peter 29 8007181534<br/>IV-228 999999<br/>Sam 54 3401018380<br/>KKK-666 80808080<br/>End<br/> 340 </td>
			<td>7801211340 <br/><br/><br/><br/><br/> <br/>&nbsp;</td>
		</tr>
	</tbody>
</table>

# 5. Birthday Celebrations
It is a well-known fact that people celebrate birthdays, it is also known that some people also celebrate their pets’ birthdays. <br/>
Extend the program from your last task to add birthdates to citizens and include a class Pet, pets have a name and a birthdate.<br/>
Encompass repeated functionality into interfaces and implement them in your classes.

You will receive from the console an unknown number of lines. Until the command "End" is received, each line will contain information in one of the following formats:

**"Citizen <name> <age> <id> <birthdate>"** for **Citizen**
  
  **"Robot <model> <id>"** for **Robot** 
  
  **"Pet <name> <birthdate"** for **Pet**. 
    
  After the "End" command on the next line, you will receive a single number representing a specific year, your task is to print all birthdates (of both Citizen and Pet) in that year in the format:
    
  **day/month/year** in the order of input.

**Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Citizen Peter 22 9010101122 10/10/1990<br/>Pet Sharo 13/11/2005<br/>Robot MK-13 558833251<br/>End<br/>1990 </td>
			<td>10/10/1990<br/><br/><br/><br/>&nbsp;</td>
		</tr>
		<tr>
			<td>Robot VV-XYZ 11213141<br/>Citizen Corso 35 7903210713 21/03/1979<br/>Citizen Kane 40 7409073566 07/09/1974<br/>End<br/>1975</td>
			<td>empty output<br/><br/><br/><br/>&nbsp;</td>
		</tr>
	</tbody>
</table>
    
# 6. Food Shortage
Your totalitarian dystopian society suffers a shortage of food, so many rebels appear.
Extend the code from your previous task with new functionality to solve this task.

Define a class Rebel which has a name, age, and group (string), names are unique - there will never be 2 Rebels/Citizens or a Rebel and Citizen with the same name.
Define an interface IBuyer which defines a method BuyFood() and an integer property Food. Implement the IBuyer interface in the Citizen and Rebel class, both Rebels and Citizens start with 0 food, when a Rebel buys food his Food increases by 5, when a Citizen buys food his Food increases by 10.

On the first line of the input you will receive an integer N - the number of people, on each of the next N lines you will receive information in one of the following formats "<name> <age> <id> <birthdate>" for a Citizen or "<name> <age><group>" for a Rebel. After the N lines, until the command "End" is received, you will receive names of people who bought food, each on a new line. Note that not all names may be valid, in case of an incorrect name - nothing should happen.

Output

The output consists of only one line on which you should print the total amount of food purchased.
  
 **Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>2<br/>Peter 25 8904041303 04/04/1989<br/>Stan 27 WildMonkeys<br/>Peter<br/>George<br/>Peter<br/>End </td>
			<td>20<br/><br/><br/><br/><br/><br/>&nbsp;</td>
		</tr>
		<tr>
			<td>4<br/>Stam 23 TheSwarm<br/>Ton 44 7308185527 18/08/1973<br/>George 31 Terrorists<br/>Pen 27 881222212 22/12/1988<br/>John<br/>Geo rge<br/>John<br/>Joro<br/>Stam<br/>Pen<br/>End</td>
			<td>15<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>&nbsp;</td>
		</tr>
	</tbody>
</table>
  
# 7. Military Elite
Create the following class hierarchy:

- Soldier - general class for Soldiers, holding id, first name, and last name.
  - Private - lowest base Soldier type, holding the salary(decimal).
    § LieutenantGeneral - holds a set of Privates under his command.
    § SpecialisedSoldier - general class for all specialized Soldiers - holds the corps of the Soldier. The corps can only be one of the following: Airforces or Marines.
      - Engineer - holds a set of Repairs. A Repair holds a part name and hours worked(int).
      - Commando - holds a set of Missions. A mission holds a code name and a state (inProgress or Finished). A Mission can be finished through the method CompleteMission().
  - Spy - holds the code number of the Spy (int).

Extract interfaces for each class. (e.g. ISoldier, IPrivate, ILieutenantGeneral, etc.) The interfaces should hold their public properties and methods (e.g. ISoldier should hold id, first name, and last name). Each class should implement its respective interface. Validate the input where necessary (corps, mission state) - input should match exactly one of the required values, otherwise, it should be treated as invalid. In case of invalid corps, the entire line should be skipped, in case of an invalid mission state, only the mission should be skipped.

You will receive from the console an unknown amount of lines containing information about soldiers until the command "End" is received. The information will be in one of the following formats:
- Private: "Private <id> <firstName> <lastName> <salary>"
- LeutenantGeneral: "LieutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>" where privateXId will always be an Id of a Private already received through the input.
- Engineer: "Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>" where repairXPart is the name of a repaired part and repairXHours the hours it took to repair it (the two parameters will always come paired).
- Commando: "Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName> <mission1state> … <missionNCodeName> <missionNstate>" a missions code name, description and state will always come together.
- Spy: "Spy <id> <firstName> <lastName> <codeNumber>"

Define proper constructors. Avoid code duplication through abstraction. Override ToString() in all classes to print detailed information about the object.
- Privates: Name: <firstName> <lastName> Id: <id> Salary: <salary>
- Spy: Name: <firstName> <lastName> Id: <id> Code Number: <codeNumber>
- LieutenantGeneral: Name: <firstName> <lastName> Id: <id> Salary: <salary> Privates: <private1 ToString()> <private2 ToString()>

… <privateN ToString()>

- Engineer: Name: <firstName> <lastName> Id: <id> Salary: <salary> Corps: <corps> Repairs: <repair1 ToString()> <repair2 ToString()> … <repairN ToString()>

- Commando: Name: <firstName> <lastName> Id: <id> Salary: <salary> Corps: <corps> Missions: <mission1 ToString()> <mission2 ToString()> … <missionN ToString()>

- Repair: Part Name: <partName> Hours Worked: <hoursWorked>

- Mission: Code Name: <codeName> State: <state>

NOTE: Salary should be printed rounded to two decimal places after the separator.  
  
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Private 1 Peter Johnson 22.22<br/>Commando 13 Sam Peterson 13.1 Airforces<br/>Private 222 Tony Samthon 80.08<br/>LieutenantGeneral 3 George Stevenson 100 222 1<br/>End<br/><br/><br/> <br/>&nbsp;</td>
			<td>Name: Peter Johnson Id: 1 Salary: 22.22<br/> Name: Sam Peterson Id: 13 Salary: 13.10<br/> Corps: Airforces<br/> Missions:<br/> Name: Tony Samthon Id: 222 Salary: 80.08<br/> Name: George Stevenson Id: 3 Salary: 100.00<br/> Privates:<br/> &nbsp;&nbsp;Name: Tony Samthon Id: 222 Salary: 80.08<br/> &nbsp;&nbsp;Name: Peter Johnson Id: 1 Salary: 22.22 </td>
		</tr>
		<tr>
			<td>Engineer 7 Peter Johnson 12.23 Marines Boat 2<br/>Crane 17<br/>Commando 19 George Stevenson 150.15 Airforces<br/>HairyFoot finished Freedom inProgress<br/>End<br/><br/><br/><br/>&nbsp; </td>
			<td>Name: Peter Johnson Id: 7 Salary: 12.23<br/> Corps: Marines<br/> Repairs:<br/> &nbsp;&nbsp;Part Name: Boat Hours Worked: 2<br/>&nbsp;&nbsp;Part Name: Crane Hours Worked: 17<br/> Name: George Stevenson Id: 19 Salary: 150.15<br/> Corps: Airforces<br/> Missions:<br/>&nbsp;&nbsp; Code Name: Freedom State: inProgress </td>
		</tr>
	</tbody>
</table>
