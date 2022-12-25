# 1.	Sign of Integer Numbers
A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result print:
-	For positive number: "The number {number} is positive. "
-	For negative number: "The number {number} is negative. "
-	For zero number: "The number {number} is zero. "

**Examples:**

Input|	Output
---|---
 2|	The number 2 is positive.
-9|	The number -9 is negative.

# 2.	Grades
Create a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade definition:
-	2.00 – 2.99 - "Fail"
-	3.00 – 3.49 - "Poor"
-	3.50 – 4.49 - "Good"
-	4.50 – 5.49 - "Very good"
-	5.50 – 6.00 - "Excellent"

**Examples:**

Input|	Output
---|---
3.33|Poor
4.50|Very good
2.99|Fail

# 3.	Calculations
Create a program that receives three lines of input:
-	On the first line, a string - "add", "multiply", "subtract", "divide"
-	On the second line, a number
-	On the third line, another number

You should create four methods (for each calculation) and invoke the corresponding method depending on the command. 
The method should also print the result (needs to be void).

**Examples:**

Input|	Output
---|---
subtract|1
5|
4|
Input|	Output
divide|2
8|
4|

# 4.	Printing Triangle
Create a method for printing triangles as shown below:

**Examples:**

Input|	Output
---|---
3|	1
||1 2
||1 2 3
||1 2
||1
2|	1
||1 2
||1

# 5.	Orders
Create a program that calculates and prints the total price of an order. The method should receive two parameters:
-	A string, representing a product - "coffee",  "water", "coke", "snacks"
-	An integer, representing the quantity of the product
The prices for a single item of each product are:
-	coffee – 1.50
-	water – 1.00
-	coke – 1.40
-	snacks – 2.00

Print the result rounded to the second decimal place.

**Examples:**

Input|Output
---|---
water|5.00
5|	
Input|Output
coffee|3.00
2|	

# 6.	Calculate Rectangle Area
Create a method that calculates and returns the area of a rectangle. 

**Examples:**

Input|	Output
---|---
3|12
4	|
Input|	Output
6|12
2	|

# 7.	Repeat String
Create a method that receives two parameters:
-	A string 
-	A number n (integer) represents how many times the string will be repeated
 
 The method should return a new string, containing the initial one, repeated n times without space. 

**Examples:**

Input|	Output
---|---
abc|abcabcabc
3	|
Input|	Output
String|StringString
2	|

# 8.	Math Power
Create a method, which receives two numbers as parameters:
-	The first number – the base
-	The second number – the power
 
 The method should return the base rase to the given power.

**Examples:**
Input|	Output|Input|	Output
---|---|---|---
2|256|3|81
8||4|

# 9.	Greater of Two Values
You are given an input of two values of the same type. The values can be of type int, char, or string. Create methods called GetMax(), 
which can compare int, char, or string and returns the biggest of the two values.

**Examples:**

Input|	Output|Input|	Output|Input|	Output
---|---|---|---|---|---
int|16|char|z|string|bbb
2||a||aaa|
16||z||bbb|

# 10.	Multiply Evens by Odds
Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
-	Create a method called GetMultipleOfEvenAndOdds()
-	Create a method GetSumOfEvenDigits()
-	Create GetSumOfOddDigits()
-	You may need to use Math.Abs() for negative numbers

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
-12345|54|3453466|220

# 11.	Math Operations
Write a method that receives two numbers and an operator, calculates the result, and returns it. You will be given three lines of input. 
The first will be the first number, the second one will be the operator and the last one will be the second number.

The possible operators are: /, *, + and -.

**Examples:**

Input	|Output
---|---
5|25
\*|
5|
Input	|Output
4|12
+|
8	|
