# Bombs

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
		
# Snake
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

# Parking
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

# Flower Wreaths
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

