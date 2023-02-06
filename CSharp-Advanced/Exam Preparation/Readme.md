# 1. Bombs

Ezio still is learning to make bombs. With their help, he will save civilization. We should help Ezio to make his perfect bombs.

You will be given a two sequence of integers, representing bomb effects and bomb casings.<br/>
You need to start from the first bomb effect and try to mix it with the last bomb casing.<br/>
If the sum of their values is equal to any of the materials in the table below – create the bomb corresponding to the value and remove the both bomb materials.<br/>
Otherwise, just decrease the value of the bomb casing by 5. You need to stop combining when you have no more bomb effects or bomb casings, 
or you successfully filled the bomb pouch.<br/>
Bombs:
-	Datura Bombs: 40
-	Cherry Bombs: 60
-	Smoke Decoy Bombs: 120

To fill the bomb pouch, Ezio needs three of each of the bomb types.

**Input**
-	On the first line, you will receive the integers representing the bomb effects, separated by ", ".
-	On the second line, you will receive the integers representing the bomb casing, separated by ", ".

**Output**
-	On the first line of output – print one of these rows according whether Ezio succeeded fulfill the bomb pouch:<br/>
"Bene! You have successfully filled the bomb pouch!"<br/>
"You don't have enough materials to fill the bomb pouch."

-	On the second line - print all bomb effects left:<br/>
If there are no bomb effects: "Bomb Effects: empty"<br/>
If there are effects: "Bomb Effects: {bombEffect1}, {bombEffect2}, (…)"

-	On the third line - print all bomb casings left:<br/>
If there are no bomb casings: "Bomb Casings: empty"<br/>
If there are casings: "Bomb Casings: {bombCasing1}, {bombCasing2}, (…)"

-	Then, you need to print all created bombs and the count you have of them, ordered alphabetically:<br/>
"Cherry Bombs: {count}"<br/>
"Datura Bombs: {count}"<br/>
"Smoke Decoy Bombs: {count}"

**Constraints**
-	All of the given numbers will be valid integers in the range [0, 120].
-	Don't have situation with negative material.
**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>5, 25, 50, 115<br/><br/>5, 15, 25, 35
 </td>
			<td>You don't have enough materials to fill the bomb pouch.<br/>Bomb Effects: empty<br/>Bomb Casings: empty<br/>Cherry Bombs: 1<br/>Datura Bombs: 2<br/>
Smoke Decoy Bombs: 1
 </td>
			<td>30, 40, 5, 55, 50, 100, 110, 35, 40, ${\color{yellow}35}$, 100, 80<br/><br/>20, ${\color{red}25}$, 20, 5, 20, 20, 70, 5, 35, 0, 10
 </td>
			<td>Bene! You have successfully filled the bomb pouch!<br/>Bomb Effects: 100, 80<br/>Bomb Casings: 20<br/>Cherry Bombs: 3<br/>Datura Bombs: 4<br/>
Smoke Decoy Bombs: 3
 </td>
		</tr>
	</tbody>
</table>
		
# 2. Snake
Everyone remembers the old snake games. Now is time to create our own snake game.

You will be given an integer n for the size of the territory with square shape. On the next n lines, you will receive the rows of the territory.
The snake will be placed on a random position, marked with the letter 'S'. There will also be food on random positions, marked with '\*'. 
The territory may have lair. The lair will have two burrows marked with the letter - 'B'. All of the empty positions will be marked with '\-'.
Each turn, you will be given command for the snake’s movement. When the snake moves it leaves a trail marked with '.'

Move commands will be: "up", "down", "left", "right".

If the snake moves to a food, it will eat the food, which will increase food quantity with one.
If it goes inside to a burrow, it goes out on the position of the other burrow and then both burrows disappear. 
If the snake goes out of its territory, the game is over. The snake needs at least 10 food quantity to be fed.
If the snake goes outside of its territory or has eaten enough food, the game should end.

**Input**
-	On the first line, you are given the integer n – the size of the square matrix.
-	The next n lines holds the values for every row.
-	On each of the next lines you will get a move command.

**Output**
-	On the first line:<br/>
If the snake goes out of its territory, print: "Game over!"<br/>
If the snake eat enough food, print: "You won! You fed the snake."

-	On the second line print all food eaten: "Food eaten: {food quantity}"
-	In the end print the matrix.

**Constraints**
-	The size of the square matrix will be between [2…10].
-	There will always be 0 or 2 burrows, marked with - 'B'.
-	The snake position will be marked with 'S'.
-	The snake will always either go out of its territory or eat enough food.
-	There will be no case in which the snake will go through itself.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>6<br/>-----S<br/>----B-<br/>------<br/>------<br/>--B---<br/>--*---<br/>left<br/>down<br/>down<br/>down<br/>left

 </td>
			<td>Game over!<br/>Food eaten: 1<br/>----..<br/>----.-<br/>------<br/>------<br/>--.---<br/>--.---

 </td>
			<td>7<br/>--***S-<br/>--*----<br/>--***--<br/>---**--<br/>---*---<br/>---*---<br/>---*---<br/>left<br/>left<br/>left<br/>down<br/>down<br/>right<br/>right<br/>
down<br/>left<br/>down

 </td>
			<td>You won! You fed the snake.<br/>Food eaten: 10<br/>--....-<br/>--.----<br/>--...--<br/>---..--<br/>---S---<br/>---*---<br/>---*---

 </td>
		</tr>
	</tbody>
</table>

# 3. Parking
Parking games are also among the popular games. Let's create one.

**Preparation**
Download the skeleton provided in Judge. Do not change the StartUp class or its namespace.

**Problem description**
Your task is to create a repository, which stores items by creating the classes described below.<br/>
First, write a C# class Car with the following properties:
-	Manufacturer: string
-	Model: string
-	Year: int

The class constructor should receive manufacturer, model and year and override the ToString() method in the following format:<br/>
"{manufacturer} {model} ({year})"

Next, write a C# class Parking that has data (a collection, which stores the entity Car). All entities inside the repository have the same properties. 
Also, the Parking class should have those properties:
-	Type: string
-	Capacity: int

The class constructor should receive type and capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
-	Field data – collection that holds added cars
-	Method Add(Car car) – adds an entity to the data if there is an empty cell for the car.
-	Method Remove(string manufacturer, string model) – removes the car by given manufacturer and model, if such exists, and returns bool.
-	Method GetLatestCar() – returns the latest car (by year) or null if have no cars.
-	Method GetCar(string manufacturer, string model) – returns the car with the given manufacturer and model or null if there is no such car.
-	Getter Count – returns the number of cars.
-	GetStatistics() – returns a string in the following format:<br/>
"The cars are parked in {parking type}:<br/>
{Car1}<br/>
{Car2}<br/>
(…)"

**Constraints**
-	The combinations of manufacturers and models will be always unique.
-	The year of the cars will always be positive.
-	There won't be cars with the same years.

**Examples:**<br/>
This is an example how the Parking class is intended to be used. 
```ruby
// Initialize the repository
Parking parking = new Parking("Underground parking garage", 5);

// Initialize entity
Car volvo = new Car("Volvo", "XC70", 2010);

// Print Car
Console.WriteLine(volvo); // Volvo XC70 (2010)

// Add Car
parking.Add(volvo);

// Remove Car
Console.WriteLine(parking.Remove("Volvo", "XC90")); // False
Console.WriteLine(parking.Remove("Volvo", "XC70")); // True

Car peugeot = new Car("Peugeot", "307", 2011);
Car audi = new Car("Audi", "S4", 2005);

parking.Add(peugeot);
parking.Add(audi);

// Get Latest Car
Car latestCar = parking.GetLatestCar();
Console.WriteLine(latestCar); // Peugeot 307 (2011)

// Get Car
Car audiS4 = parking.GetCar("Audi", "S4");
Console.WriteLine(audiS4); // Audi S4 (2005)

// Count
Console.WriteLine(parking.Count); // 2

// Get Statistics
Console.WriteLine(parking.GetStatistics());
// The cars are parked in Underground parking garage:
// Peugeot 307(2011)
// Audi S4(2005)
```

# 4. Flower Wreaths
You want to go on a flowers wreath competition but to participate you have to make at least 5 flower wreaths.

You will be given two sequences of integers, representing roses and lilies. You need to start making wreaths knowing that one wreath needs 15 flowers. Your goal is to make at least 5 flower wreaths.<br/>
You will start crafting from the last lilies and the first roses. If the sum of their values is equal to 15 – create one wreath and remove them. If the sum is bigger than 15, just decrease the value of the lilies by 2. If the sum is less than 15 you have to store them for later and remove them. You need to stop combining when you have no more roses or lilies. In the end, if you have any stored flowers you should make as many wreaths as you can with them. 

**Input**
- On the first line, you will receive the integers representing the lilies, separated by ", ".
- On the second line, you will receive the integers representing the roses, separated by ", ".

**Output**
-Print whether you have succeeded making at least 5 wreaths:<br/>
"You made it, you are going to the competition with {count of wreaths} wreaths!"<br/>
"You didn't make it, you need {wreaths needed} wreaths more!"

**Constraints**
- All of the given numbers will be valid integers in the range [0, 120].
- Don't have situation with negative number.

**Examples:**
<table style="width: 10%;border-collapse: collapse;" border = "2" cellpadding = "10">
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>10, 15, 2, 7, 9, 13<br/>2, 10, 8, 12, 0, 5

 </td>
			<td>You made it, you are going to the competition<br/> with 5 wreaths!


 </td>
			<td>10, 5, 3, 7, 8<br/>5, 10, 8, 7, 6

 </td>
			<td>You didn't make it, you need<br/> 1 wreaths more!

 </td>
		</tr>
	</tbody>
</table>

# 5. Bee
You will be given an integer n for the size of the bee territory with square shape. On the next n lines, you will receive the rows of the territory. The bee will be placed on a random position, marked with the letter 'B'. On random positions there will be flowers, marked with 'f'. There may also be а bonus on the territory. There will always be only one bonus. It will be marked with the letter - 'O'. All of the empty positions will be marked with '.'.<br/>
Each turn, you will be given a command for the bee’s movement.

The commands will be: "up", "down", "left", "right", "End".

If the bee moves to a flower, it pollinates the flower and increases the pollinated flowers with one.
If it goes to a bonus, the bee gets a bonus one move forward and then the bonus disappears. If the bee goes out she can't return back and the program ends. If the bee receives the "End" command the program ends. The bee needs at least 5 pollinated flowers.

**Input**
- On the first line, you are given the integer n – the size of the square matrix.
- The next n lines hold the values for every row.
- On each of the next lines, until you receive "End" command,  you will receive a move command.

**Output**
-On the first line:<br/>
If the bee goes out of its territory print: "The bee got lost!"
- On the second line:<br/>
If the bee couldn’t pollinate enough flowers, print: "The bee couldn't pollinate the flowers, she needed {needed} flowers more"<br/>
If the bee successfully pollinated enough flowers, print: "Great job, the bee managed to pollinate {polinationed flowers} flowers!"<br/>
-In the end print the matrix.

**Constraints**
- The size of the square matrix will be between [2…10].
- There will always be 0 or 1 bonus, marked with - 'O'.
- The bee position will be marked with 'B'.
- There won't be a case where a bonus moves the bee out of its territory.

**Examples:**
<table style="width: 10%;border-collapse: collapse;" border = "2" cellpadding = "10">
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>5<br/>Bff..<br/>..O..<br/>f.f.f<br/>.....<br/>fffff<br/>right<br/>right<br/>down<br/>left<br/>left<br/>down<br/>down<br/>right<br/>down


 </td>
			<td>The bee got lost!<br/>Great job, the bee managed to pollinate 6 flowers!<br/>.....<br/>.....<br/>....f<br/>.....<br/>..fff



 </td>
			<td>4<br/>....<br/>.O..<br/>ff..<br/>f.B.<br/>left<br/>left<br/>up<br/>right<br/>up<br/>End


 </td>
			<td>The bee couldn't pollinate the flowers, she needed 2 flowers more<br/>.B..<br/>....<br/>....<br/>....


 </td>
		</tr>
	</tbody>
</table>

# 6. Vet Clini
Problem description
Your task is to create a repository, which stores items by creating the classes described below.
First, write a C# class Pet with the following properties:
- Name: string
- Age: int
- Owner: string

The class constructor should receive name, age and owner. The class should override the ToString() method in the following format:

"Name: {Name} Age: {Age} Owner: {Owner}"

Next, write a C# class Clinic that has data (a collection, which stores the Pets). All entities inside the repository have the same properties. Also, the Clinic class should have those properties:
- Capacity: int
The class constructor should receive capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
- Field data – collection that holds added pets
- Method Add(Pet pet) – adds an entity to the data if there is an empty cell for the pet.
- Method Remove(string name) – removes the pet by given name, if such exists, and returns bool.
- Method GetPet(string name, string owner) – returns the pet with the given name and owner or null if no such pet exists.
- Method GetOldestPet() – returns the oldest Pet.
- Getter Count – returns the number of pets.
- GetStatistics() – returns a string in the following format:

"The clinic has the following patients:<br/>
Pet {Name} with owner: {Owner}<br/>
Pet {Name} with owner: {Owner}<br/>
   (…)"

**Constraints**
- The combinations of names and owners will always be unique.
- The age of the pets will always be positive.

**Examples:**
This is an example of how the Clinic class is intended to be used. 
```ruby
// Initialize the repository
Clinic clinic = new Clinic(20);

// Initialize entity
Pet dog = new Pet("Ellias", 5, "Tim");

// Print Pet
Console.WriteLine(dog); // Ellias 5 (Tim)

// Add Pet
clinic.Add(dog);

// Remove Pet
Console.WriteLine(clinic.Remove("Ellias")); // True
Console.WriteLine(clinic.Remove("Pufa")); // False

Pet cat = new Pet("Bella", 2, "Mia");
Pet bunny = new Pet("Zak", 4, "Jon");

clinic.Add(cat);
clinic.Add(bunny);

// Get Oldest Pet
Pet oldestPet = clinic.GetOldestPet();
Console.WriteLine(oldestPet); // Zak 4 (Jon)

// Get Pet
Pet pet = clinic.GetPet("Bella", "Mia");
Console.WriteLine(pet); // Bella 2 (Mia)

// Count
Console.WriteLine(clinic.Count); // 2

// Get Statistics
Console.WriteLine(clinic.GetStatistics());
//The clinic has the following patients:
//Bella Mia
//Zak Jon
```

# 07.Scheduling 
You are hired to create a program that schedules the work of a CPU and avoids tasks that could harm it.
On the first line you will be given some tasks as integer values, separated by comma and space ", ". On the second line you will be given some threads as integer values, separated by a single space. On the third line, you will receive the integer value of a task that you need to kill. Your job is to stop the work of the CPU as soon as you get to this task, otherwise your CPU will crash. The thread that gets first to this task, kills it.
The CPU works in the following way:
- It takes the first given thread value and the last given task value.
- If the thread value is greater than or equal to the task value, the task and thread get removed.
- If the thread value is less than the task value, the thread gets removed, but the task remains.
After you finish the needed task, print on a single line:<br/>
"Thread with value {thread} killed task {taskToBeKilled}"

Then print the remaining threads (including the one that killed the task) starting from the first on a single line, separated by a single space.

**Input**
- On the first line you will receive the tasks, separated by ", ".
- On the second line you will the threads, separated by a single space.
- On the third line, you will receive a single integer – value of the task to be killed.

**Output**
- Print the thread that killed the task and task itself in the format given above.
- Print the remaining threads starting from the first on a single line, separated by a single space.

**Constraints**
- The needed task will always be with a unique value
- You will always have enough threads to get to the needed task

**Examples:**
<table style="width: 10%;border-collapse: collapse;" border = "2" cellpadding = "10">
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>20, 23, 54, 34, 90<br/>150 64 20 34<br/>54


 </td>
			<td>Thread with value 20 killed task 54<br/>20 34




 </td>
			<td>33, 12, 15, 40, 45, 60<br/>30 20 53 67 84 90<br/>40



 </td>
			<td>Thread with value 90 killed task 40<br/>90



 </td>
		</tr>
	</tbody>
</table>

# 08. Garden 
Furion loves nature and that is why he has a beautiful square garden. He wants to plant it with magical flowers, so it can be even more beautiful. No one knows why, but he actually needs a software program to do that, that is why you'll write one for him.
You will be given N and M – integers, indicating the dimensions of the square garden. The garden is empty at the beginning – it has no flowers. Furion wants every place for a flower to be presented with a zero (0) when it is empty. After you finish creating the garden, you will start receiving two integers – Row and Column, separated by a single space – which represent the position at which Furion currently plants a flower. If you receive a position, which is outside of the garden, you should print "Invalid coordinates." and move on with the next position.<br/> This happens until you receive the command "Bloom Bloom Plow”. When you receive that input, all planted flowers should bloom.

The flowers are magical. When a flower blooms it instantly blooms flowers to all places to its left, right, up, and down, increasing their value with 1. Flowers can bloom multiple times, and each time the flower blooms – it becomes more and more beautiful, which means its value increases by 1. 

**Input**
- On the first line of input you will receive two integers, separated by a single space – indicating the dimensions of the garden.
- On the next several lines you will be receiving two integers separated by a single space – indicating the position at which Furion currently plants a flower.
- When you receive the input line "Bloom Bloom Plow” the input sequence should end.

**Output**
- Print "Invalid coordinates." each time you receive positions outside the garden.
- The output is simple. Print the whole garden – each row of it on a new line, and each column – separated by a single space.

**Constraints**
- The dimensions of the matrix (N and M) will contains be integers in the range [3, 500].
- The amount of input commands will be in the range [0, N * M].
- Flowers will always be planted on empty places.
**Examples:**

<table style="width: 10%;border-collapse: collapse;" border = "2" cellpadding = "10">
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>5 5<br/>1 1<br/>3 3<br/>Bloom Bloom Plow


 </td>
			<td>0 1 0 1 0<br/>1 1 1 2 1<br/>0 1 0 1 0<br/>1 2 1 1 1<br/>0 1 0 1 0





 </td>
			<td>4 4<br/>0 0<br/>3 3<br/>1 1<br/>2 2<br/>Bloom Bloom Plow




 </td>
			<td>1 2 2 2<br/>2 1 2 2<br/>2 2 1 2<br/>2 2 2 1




 </td>
		</tr>
	</tbody>
</table>

# 09. Classroom
Problem description
Your task is to create a repository, which stores items by creating the classes described below.
First, write a C# class Student with the following properties:
- FirstName: string
- LastName: string
- Subject: string

The class constructor should receive firstName, lastName and subject.  You need to create the appropriate getters and setters.<br/> 
The class should override the ToString() method in the following format: "Student: First Name = {firstName}, Last Name = {lastName}, Subject = {subject}"

Next, write a C# class Classroom that has students (a collection, which stores the students) and a certain capacity. All entities inside the repository have the same fields. Also, the Classroom class should have the following properties:
- Capacity: int
- Count: int – returns the number of students in the classroom
The class constructor should receive capacity, also it should initialize the students with a new instance of the collection. Implement the following features:
- Field students – collection that holds added students
- Method RegisterStudent(Student student) – adds an entity to the students if there is an empty seat for the student.<br/>
Returns "Added student {firstName} {lastName}" if the student is successfully added<br/>
Returns "No seats in the classroom" – if there are no more seats in the classroom<br/>
- Method DismissStudent(string firstName, string lastName) – removes the student by the given names<br/>
Returns "Dismissed student {firstName} {lastName}" if the student is successfully dismissed<br/>
Returns "Student not found" if the student is not in the classroom<br/>
- Method GetSubjectInfo(string subject) – returns all the students with the given subject in the following format:<br/>
"Subject: {subjectName}<br/>
Students:<br/>
{firstName} {lastName}<br/>
{firstName} {lastName}<br/>
…"

Returns "No students enrolled for the subject" if the student is not in the classroom

- Method GetStudentsCount() – returns the count of the students in the classroom.
-Method GetStudent(string firstName, string lastName) – returns the student with the given names. 
 **Constraints**
- The combinations of names will always be unique.
- The capacity will always be a positive number.



**Examples:**
This is an example of how the Classroom class is intended to be used. 
```ruby
// Initialize the repository
Classroom classroom = new Classroom(10);
// Initialize entities
Student student = new Student("Peter", "Parker", "Geometry");
Student studentTwo = new Student("Sarah", "Smith", "Algebra");
Student studentThree = new Student("Sam", "Winchester", "Algebra");
Student studentFour = new Student("Dean", "Winchester", "Music");
// Print Student
Console.WriteLine(student); // Student: First Name = Peter, Last Name = Parker, Subject = Geometry
// Register Student
string register = classroom.RegisterStudent(student);
Console.WriteLine(register); // Added student Peter Parker
string registerTwo = classroom.RegisterStudent(studentTwo);
string registerThree = classroom.RegisterStudent(studentThree);
string registerFour = classroom.RegisterStudent(studentFour);
// Dismiss Student
string dismissed = classroom.DismissStudent("Peter", "Parker");
Console.WriteLine(dismissed); // Dismissed student Peter Parker
string dismissedTwo = classroom.DismissStudent("Ellie", "Goulding");
Console.WriteLine(dismissedTwo); // Student not found
// Subject info
string subjectInfo = classroom.GetSubjectInfo("Algebra");
Console.WriteLine(subjectInfo);
// Subject: Algebra
// Students:
// Sarah Smith
// Sam Winchester
string anotherInfo = classroom.GetSubjectInfo("Art");
Console.WriteLine(anotherInfo); // No students enrolled for the subject
// Get Student
Console.WriteLine(classroom.GetStudent("Dean", "Winchester")); 
// Student: First Name = Dean, Last Name = Winchester, Subject = Music

```

# 10. Cooking
You are asked to cook baked foods for the near bakery, because your recipes are so great. You need to mix liquids with ingredients to cook the required delicacies.
First, you will be given a sequence of integers, representing liquids. Afterwards, you will be given another sequence of integers representing ingredients.
You need to start from the first liquid and try to mix it with the last ingredient. If the sum of their values is equal to any of the items in the table below – cook the food corresponding to the value and remove both the liquid and the ingredient. Otherwise, remove only the liquid and increase the value of the ingredient by 3.<br/>
You need to stop cooking when you have no more liquids or ingredients.

Food|Value needed
---|---
Bread|	25
Cake|	50
Pastry|	75
Fruit Pie|100

In order to cook enough food for the bakery, you need one of each of the foods. 

**Input**
- On the first line, you will receive the integers representing the liquids, separated by a single space. 
- On the second line, you will receive the integers representing the ingredients, separated by a single space.

**Output**
- On the first line of output – print if you succeeded in cooking everything:
  - "Wohoo! You succeeded in cooking all the food!" 
  - "Ugh, what a pity! You didn't have enough materials to cook everything." 
- On the second line - print all liquids you have left:
  - If there are no liquids: "Liquids left: none"
  - If there are liquids: "Liquids left: {liquid1}, {liquid2}, {liquid3}, (…)"
- On the third line - print all ingredients you have left:
  - If there are no items: "Ingredients left: none"
  - If there are items: "Ingredients left: {ingredient}, {ingredient}, {ingredient}, (…)"
- Then, you need to print all products you have cooked and the amount you have of them, ordered alphabetically:<br/>
"Bread: {amount}"<br/>
"Cake: {amount}"<br/>
"Fruit Pie: {amount}"<br/>
"Pastry: {amount}"<br/>

**Constraints**
- All of the given numbers will be valid integers in the range [0, 100].

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>1 25 50 50<br/>50 25 25 24
 </td>
			<td>Wohoo! You succeeded in cooking all the food!<br/>Liquids left: none<br/>Ingredients left: none<br/>Bread: 1<br/>Cake: 1<br/>Fruit pie: 1
<br/>Pastry: 1
 </td>
		</tr>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>10 20 30 40 50<br/>50 40 30 30 15
 </td>
			<td>Ugh, what a pity! You didn't have enough materials to cook everything.<br/>Liquids left: none<br/>Ingredients left: 39, 40, 50<br/>
Bread: 1<br/>Cake: 1<br/>Fruit pie: 0<br/>Pastry: 0
		</tr>
	</tbody>
</table>

# 11. Selling 
You successfully started your cooking journey, so now you need to sell the products from your basket  in the bakery in order to collect your price.
You will be given an integer n for the size of the bakery with square shape. On the next n lines, you will receive the rows of the bakery. You will be placed on a random position, marked with the letter 'S'. On random positions there will be clients, marked with a single digit. There may also be pillars. Their count will be either 0 or 2 and they are marked with the letter - 'O'. All of the empty positions will be marked with '-'.<br/>
Each turn, you will be given commands for the your movement. Move commands will be: "up", "down", "left", "right". If you move to a client, you collects the price equal to the digit there and the client disappears. If you move to a pillar, you move on the position of the other pillar and then both pillars disappear. If you go out of the bakery, you disappear from the bakery and you are out of there. You need at least 50 dollars to rent your own Bakery
When you are out of the bakery or you collect enough money, the program ends.

**Input**
- On the first line, you are given the integer n – the size of the square matrix.
- The next n lines holds the values for every row.
- On each of the next lines you will get a move command.

**Output**
- On the first line:
  - If the player goes to the void, print: "Bad news, you are out of the bakery."
  - If the player collects enough star power, print: "Good news! You succeeded in collecting enough money!"
- On the second line print all star power collected: "Money: {money}"
- In the end print the matrix.

**Constraints**
- The size of the square matrix will be between [2…10].
- There will always be 0 or 2 pillars, marked with the letter - 'O'.
- Your position will be marked with 'S'.
- You will always go out of the bakery or collect enough money.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>5<br/>SO---<br/>-----<br/>-----<br/>-----<br/>----O<br/>right<br/>right
 </td>
			<td>Bad news, you are out of the bakery.<br/>Money: 0<br/>-----<br/>-----<br/>-----<br/>-----<br/>-----
 </td>
			<td>6<br/>S98---<br/>99----<br/>666666<br/>------<br/>--77--<br/>-6-6-6<br/>right<br/>right<br/>down<br/>left<br/>left<br/>down<br/>right
<br/>right
 </td>
			<td>Good news! You succeeded in collecting enough money!<br/>Money: 53<br/>------<br/>------<br/>--S666<br/>------<br/>--77--<br/>-6-6-6
 </td>
		</tr>
	</tbody>
</table>

# 12. Openning
Now that you successfully saved money for your own Bakery ,you need to recruit some employees to work there. You are You should build a system for that.<br/>
Problem description<br/>
Your task is to create a repository, which stores departments by creating the classes described below.
First, write a C# class Employee with the following properties:
-Name: string
-Age: int
-Country: string
The class constructor should receive name, age and country and override the ToString() method in the following format:<br/>
"Employee: {name}, {age} ({country})"<br/>
Next, write a C# class Bakery that has data (a collection, which stores the entity Employee). All entities inside the repository have the same properties. Also, the Bakery class should have those properties:
- Name: string
- Capacity: int<br/>
The class constructor should receive name and capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
- Field data – collection that holds added Employees
- Method Add(Employee employee) – adds an entity to the data if there is room for him/her.
- Method Remove(string name) – removes an employee by given name, if such exists, and returns bool.
- Method GetOldestEmployee() – returns the oldest employee.
- Method GetEmployee(string name) – returns the employee with the given name.
- Getter Count – returns the number of employees.
- Report() – returns a string in the following format:<br/>
"Employees working at Bakery {bakeryName}:<br/>
{Employee1}<br/>
{Employee2}<br/>
(…)"<br/>
**Constraints**
- The names of the employees will be always unique.
- The age of the employees will always be with positive values.
- You will always have an employee added before receiving methods manipulating the Space Station’s Employees.

**Examples:**
This is an example how the Bakery class is intended to be used. 
```ruby
//Initialize the repository
Bakery bakery = new Bakery("Barny", 10);
//Initialize entity
Employee employee = new Employee("Stephen", 40, "Bulgaria");
//Print Employee
Console.WriteLine(employee); //Employee: Stephen, 40 (Bulgaria)

//Add Employee
bakery.Add(employee);
//Remove Employee
Console.WriteLine(bakery.Remove("Employee name")); //false

Employee secondEmployee = new Employee("Mark", 34, "UK");

//Add Employee
bakery.Add(secondEmployee);

Employee oldestEmployee = bakery.GetOldestEmployee(); // Employee with name Stephen
Employee employeeStephen = bakery.GetEmployee("Stephen"); // Employee with name Stephen
Console.WriteLine(oldestEmployee); //Employee: Stephen, 40 (Bulgaria)
Console.WriteLine(employeeStephen); //Employee: Stephen, 40 (Bulgaria)

Console.WriteLine(bakery.Count); //2

Console.WriteLine(bakery.Report());
//Employees working at Bakery Barny:
//Employee: Stephen, 40 (Bulgaria)
//Employee: Mark, 34 (UK)

```
