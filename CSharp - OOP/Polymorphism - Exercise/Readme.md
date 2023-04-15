# 1. Vehicles
Create a program that models 2 vehicles (a Car and a Truck) and simulates driving and refueling them.

Car and truck both have fuel quantity, fuel consumption in liters per km, and can be driven a given distance and refueled with a given amount of fuel.
It's summer, so both vehicles use air conditioners and their fuel consumption per km is increased by 0.9 liters for the car and with 1.6 liters for the truck.
Also, the truck has a tiny hole in its tank and when it’s refueled it keeps only 95% of the given fuel. 
The car has no problems and adds all the given fuel to its tank. If a vehicle cannot travel the given distance, its fuel does not change.

**Input**
- On the first line – information about the car in the format: "Car {fuel quantity} {liters per km}"
- On the second line – info about the truck in the format: "Truck {fuel quantity} {liters per km}"
- On the third line – the number of commands N that will be given on the next N lines
- On the next N lines – commands in the format:
  - "Drive Car {distance}"
  - "Drive Truck {distance}"
  - "Refuel Car {liters}"
  - "Refuel Truck {liters}"

**Output**
- After each Drive command, if there was enough fuel, print on the console a message in the format:
  - "Car/Truck travelled {distance} km"
- If there was not enough fuel, print: "Car/Truck needs refueling"
- After the End command, print the remaining fuel for both the car and the truck, rounded to 2 digits after the floating point in the format:
  - "Car: {liters}"
  - "Truck: {liters}"

**Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td> Car 15 0.3<br/>Truck 100 0.9<br/>4<br/>Drive Car 9<br/>Drive Car 30<br/>Refuel Car 50<br/>Drive Truck 10</td>
			<td> Car travelled 9 km<br/> Car needs refueling<br/> Truck travelled 10 km<br/> Car: 54.20<br/> Truck: 75.00<br/><br/>&nbsp;</td>
		</tr>
		<tr>
			<td>Car 30.4 0.4<br/>Truck 99.34 0.9<br/>5<br/>Drive Car 500<br/>Drive Car 13.5<br/> Refuel Truck 10.300<br/> Drive Truck 56.2<br/> Refuel Car 100.2 </td>
			<td> Car needs refueling<br/> Car travelled 13.5 km<br/> Truck needs refueling<br/> Car: 113.05<br/>Truck: 109.13<br/><br/><br/>&nbsp;</td>
		</tr>
	</tbody>
</table>

# 2. Vehicles Extension
Use your solution of the previous task for the starting point and add more functionality. Add a new vehicle – Bus. Add to every vehicle a new property – tank capacity. A vehicle cannot start with or refuel above its tank capacity.

If you try to put more fuel in the tank than the available space, print on the console "Cannot fit {fuel amount} fuel in the tank" and do not add any fuel in the vehicle’s tank. If you try to create a vehicle with more fuel than its tank capacity, create it but start with an empty tank.

Add a new command for the bus. You can drive the bus with or without people. With people, the air-conditioner is turned on and its fuel consumption per kilometer is increased by 1.4 liters. If there are no people on the bus, the air-conditioner is turned off and does not increase the fuel consumption.

Finally, add validation for the amount of fuel given to the Refuel command – if it is 0 or negative, print "Fuel must be a positive number".

**Input**
- On the first three lines you will receive information about the vehicles in the format:
  - "Vehicle {initial fuel quantity} {liters per km} {tank capacity}"
- On the fourth line - the number of commands N that will be given on the next N lines
- On the next N lines - commands in format:
  - "Drive Car {distance}"
  - "Drive Truck {distance}"
  - "Drive Bus {distance}"
  - "DriveEmpty Bus {distance}"
  - "Refuel Car {liters}"
  - "Refuel Truck {liters}"
  - "Refuel Bus {liters}"

**Output**
- After each Drive command, if there was enough fuel, print on the console a message in the format:
  - "Car/Truck travelled {distance} km"
- If there was not enough fuel, print:
  - "Car/Truck needs refueling"
- If you try to refuel with an amount ≤ 0 print:
  - "Fuel must be a positive number"
- If the given fuel cannot fit in the tank, print:
  - "Cannot fit {fuel amount} fuel in the tank"
- After the "End" command, print the remaining fuel for all vehicles, rounded to 2 digits after the floating point in the format:
  - "Car: {liters}"
  - "Truck: {liters}"
  - "Bus: {liters}"

**Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Car 30 0.04 70<br/>Truck 100 0.5 300<br/>Bus 40 0.3 150<br/>8<br/>Refuel Car -10<br/>Refuel Truck 0<br/>Refuel Car 10<br/>Refuel Car 300<br/>Drive Bus 10<br/>Refuel Bus 1000<br/>DriveEmpty Bus 100<br/>Refuel Truck 1000</td>
			<td>Fuel must be a positive number<br/> Fuel must be a positive number<br/> Cannot fit 300 fuel in the tank<br/> Bus travelled 10 km<br/> Cannot fit 1000 fuel in the tank<br/> Bus needs refueling<br/> Cannot fit 1000 fuel in the tank<br/> Car: 40.00<br/> Truck: 100.00<br/> Bus: 23.00<br/><br/>&nbsp;</td>
		</tr>
	</tbody>
</table>

# 3. Raiding
Your task is to create a class hierarchy like the one described below. The BaseHero class should be abstract.
- BaseHero – string Name, int Power, string CastAbility()
  - Druid – power = 80
  - Paladin – power = 100
  - Rogue – power = 80
  - Warrior – power = 100

Each hero should override the CastAbility() method:

Druid - "{Type} - {Name} healed for {Power}"

Paladin - "{Type} - {Name} healed for {Power}"

Rogue - "{Type} - {Name} hit for {Power} damage"

Warrior - "{Type} - {Name} hit for {Power} damage"

Now use the classes you created to form a raid group and defeat a boss. You will receive an integer N from the console. <br/>
On the next lines, you will receive **{heroName}** and **{heroType}** until you create N number of heroes. <br/>
If the hero type is invalid print: **"Invalid hero!"** and don’t add it to the raid group. After the raid group is formed you will receive an integer from the console which will be the boss’s power.
Then each of the heroes in the raid group should cast his ability once. You should sum the power of all of the heroes and if the total power is greater or equal to the boss’s power you have defeated him and you should print:

**"Victory!"**

Else print:

**"Defeat..."**

**Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td> 3<br/>Mike<br/>Paladin<br/>Josh<br/>Druid<br/>Scott<br/>Warrior<br/>250</td>
			<td> Paladin - Mike healed for 100<br/> Druid - Josh healed for 80<br/> Warrior - Scott hit for 100 damage<br/> Victory!<br/><br/><br/><br/>&nbsp;</td>
		</tr>
		<tr>
			<td>2<br/>Mike<br/>Warrior<br/>Tom<br/>Rogue<br/>20 </td>
			<td> Warrior - Mike hit for 100 damage<br/> Rogue - Tom hit for 80 damage<br/> Defeat...<br/><br/><br/>&nbsp;</td>
		</tr>
	</tbody>
</table>

# 4. Wild Farm
Your task is to create a class hierarchy like the one described below. The Animal, Bird, Mammal, Feline, and Food classes should be abstract. Override the method ToString().
- Food – int Quantity
  - Vegetable
  - Fruit
  - Meat
  - Seeds
- Animal – string Name, double Weight, int FoodEaten
  - Bird – double WingSize
    - Owl
    - Hen
  - Mammal – string LivingRegion
    - Mouse
    - Dog
    - Feline – string Breed
      - Cat
      -  Tiger

All animals should also have the ability to ask for food by producing a sound.
- Owl – "Hoot Hoot"
- Hen – "Cluck"
- Mouse – "Squeak"
- Dog – "Woof!"
- Cat – "Meow"
- Tiger – "ROAR!!!"

Now use the classes that you have created to instantiate some animals and feed them. Input should be read from the console. <br/>
Every even line (starting from 0) will contain information about an animal in the following format:
- Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}"
- Birds - "{Type} {Name} {Weight} {WingSize}"
- Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}"

On the odd lines, you will receive information about a piece of food that you should give to that animal. <br/>
The line will consist of a FoodType and quantity, separated by whitespace.

Animals will only eat a certain type of food, as follows:
- Hens eat everything
- Mice eat vegetables and fruits
- Cats eat vegetables and meat
- Tigers, Dogs, and Owls eat only meat

If you try to give an animal a different type of food, it will not eat it and you should print:
- "{AnimalType} does not eat {FoodType}!"

The weight of an animal will increase with every piece of food it eats, as follows:
- Hen - 0.35
- Owl - 0.25
- Mouse - 0.10
- Cat - 0.30
- Dog - 0.40
- Tiger - 1.00

Override the ToString() method to print the information about an animal in the formats:
- Birds - "{AnimalType} [{AnimalName}, {WingSize}, {AnimalWeight}, {FoodEaten}]"
- Felines - "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"
- Mice and Dogs - "{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"

After you have read the information about the animal and the food, the animal will produce a sound (print it on the console). Next, you should try to feed it. After receiving the "End" command, print information about every animal in order of input.

**Examples:**

<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td> Mouse Jerry 0.5 Anywhere<br/>Fruit 1000<br/>Owl Tom 2.5 30<br/>Meat 5<br/>End</td>
			<td> Squeak<br/> Hoot Hoot<br/> Mouse [Jerry, 100.5, Anywhere, 1000]<br/> Owl [Tom, 30, 3.75, 5]<br/>&nbsp;</td>
		</tr>
		<tr>
			<td>Tiger Rex 167.7 Asia Bengal<br/>Vegetable 1<br/> Dog Tommy 500 Street<br/> Vegetable 150<br/> End<br/>&nbsp;</td>
			<td>ROAR!!!<br/> Tiger does not eat Vegetable!<br/> Woof!<br/> Dog does not eat Vegetable!<br/> Tiger [Rex, Bengal, 167.7, Asia, 0]<br/> Dog [Tommy, 500, Street, 0]</td>
		</tr>
	</tbody>
</table>
