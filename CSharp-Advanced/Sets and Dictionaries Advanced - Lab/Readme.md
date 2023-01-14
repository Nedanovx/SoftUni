# 1.	Count Same Values in Array
Create a program that counts in a given array of double values the number of occurrences of each value. 

**Examples:**

Input|Output|Input|Output
---|---|---|---
-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3|-2.5 - 3 times|2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3|2 - 3 times
||4 - 2 times||4 - 6 times
||3 - 4 times||5 - 4 times
||-5.5 - 1 times||3	- 7 times

# 2.	Average Student Grades
Create a program, which reads a name of a student and his/her grades and adds them to the student record, then prints the students' names 
with their grades and their average grade.

**Examples:**

Input|Output|Input|Output
---|---|---|---
7|John -> 5.20 3.20 (avg: 4.20)|4|Vlad -> 4.50 5.00 (avg: 4.75)
John 5.20|Maria -> 5.50 2.50 3.46 (avg: 3.82)|Vlad 4.50|Peter -> 3.00 3.66 (avg: 3.33)
Maria 5.50|Sam -> 2.00 3.00 (avg: 2.50)|Peter 3.00|
John 3.20||Vlad 5.00|
Maria 2.50||Peter 3.66|
Sam 2.00||
Maria 3.46||
Sam 3.00||

# 3.	Largest 3 Numbers
Read a list of integers and print the largest 3 of them. If there are less than 3, print all of them.

**Examples:**

Input|Output|Input|Output
---|---|---|---
10 30 15 20 50 5|50 30 20|20 30|30 20

# 4.	Product Shop
Create a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".  Keep in mind that if you receive a shop you already have received, you must collect its product information.

Your output must be ordered by shop name and must be in the format:

"{shop}->

Product: {product}, Price: {price}"

Note: The price should not be rounded or formatted.

**Examples:**

Input|Output|Input|Output
---|---|---|---
lidl, juice, 2.30|fantastico->|tmarket, peanuts, 2.20|GoGrill->
fantastico, apple, 1.20|Product: apple, Price: 1.2|GoGrill, meatballs, 3.30|Product: meatballs, Price: 3.3
kaufland, banana, 1.10|Product: grape, Price: 2.2|GoGrill, HotDog, 1.40|Product: HotDog, Price: 1.4
fantastico, grape, 2.20|kaufland->|tmarket, sweets, 2.20|tmarket->
Revision|Product: banana, Price: 1.1|Revision|Product: peanuts, Price: 2.2
||lidl->||Product: sweets, Price: 2.2
||Product: juice, Price: 2.3


# 5.	Cities by Continent and Country
Create a program that reads continents, countries, and their cities put them in a nested dictionary and prints them.
**Examples:**

Input|Output
---|---
9|Europe:
Europe Bulgaria Sofia|Bulgaria -> Sofia, Plovdiv
Asia China Beijing|Poland -> Warsaw, Poznan
Asia Japan Tokyo|Germany -> Berlin
Europe Poland Warsaw|Asia:
Europe Germany Berlin|China -> Beijing, Shanghai
Europe Poland Poznan|Japan -> Tokyo
Europe Bulgaria Plovdiv|Africa:
Africa Nigeria Abuja|Nigeria -> Abuja
Asia China Shanghai|


# 6.	Record Unique Names
Create a program, which will take a list of names and print only the unique names in the list.

**Examples:**

Input|Output|Input|Output
---|---|---|---
8|John|7|Lyle
John|Alex|Lyle|Bruce
Alex|Sam|Bruce|Alice
John|Alice|Alice|Easton
Sam|Peter|Easton|Shawn
Alex||Shawn
Alice||Alice
Peter||Shawn
Alex||Peter


# 7.	Parking Lot
Create a program that:
-	Records a car number for every car that enters the parking lot
-	Removes a car number when the car leaves the parking lot

The input will be a string in the format: "direction, carNumber". You will be receiving commands until the "END" command is given.
Print the car numbers of the cars, which are still in the parking lot:

**Examples:**

Input|Output|Input|Output
---|---|---|---
IN, CA2844AA|CA9999TT|IN, CA2844AA|Parking Lot is Empty
IN, CA1234TA|CA2844AA|IN, CA1234TA
OUT, CA2844AA|CA9876HH|OUT, CA2844AA
IN, CA9999TT|CA2822UU|OUT, CA1234TA
IN, CA2866HI|||END
OUT, CA1234TA
IN, CA2844AA
OUT, CA2866HI
IN, CA9876HH
IN, CA2822UU
END


# 8.	SoftUni Party
There is a party in SoftUni. Many guests are invited and there are two types of them: VIP and Regular. When a guest comes, check if he/she exists in any of the two reservation lists.

All reservation numbers will be with the length of 8 chars.

All VIP numbers start with a digit.
First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
-	"PARTY" – After this command, you will begin receiving the reservation numbers of the people, who came to the party.
-	"END" – The party is over and you have to stop the program and print the appropriate output.

In the end, print the count of the guests who didn't come to the party, and afterward, print their reservation numbers. the VIP guests must be first.

**Examples:**

Input|Output|Input|Output
---|---|---|---
7IK9Yo0h|2|m8rfQBvl|2
9NoBUajQ|7IK9Yo0h|fc1oZCE0|xys2FYzn
Ce8vwPmE|tSzE5t0p|UgffRkOn|MDzcM9ZK
SVQXQCbc||7ugX7bm0
tSzE5t0p||9CQBGUeJ
PARTY||2FQZT3uC
9NoBUajQ||dziNz78I
Ce8vwPmE||mdSGyQCJ
SVQXQCbc||LjcVpmDL
END||fPXNHpm1
|||HTTbwRmM
|||B5yTkMQi
|||8N0FThqG
|||xys2FYzn
|||MDzcM9ZK
|||PARTY
|||2FQZT3uC
|||dziNz78I
|||mdSGyQCJ
|||LjcVpmDL
|||fPXNHpm1
|||HTTbwRmM
|||B5yTkMQi
|||8N0FThqG
|||m8rfQBvl
|||fc1oZCE0
|||UgffRkOn
|||7ugX7bm0
|||9CQBGUeJ
|||END
