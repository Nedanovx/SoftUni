# 1.	Student Information
Create a program that receives 3 lines of input:
-	student name 
-	age
-	average grade. 

Your task is to print all the info about the student in the following format: "Name: {student name}, Age: {student age}, Grade: {student grade}".

**Examples:**

Input	| Output|
---   | ---
John  |Name: John, Age: 15, Grade: 5.40
15    |
5.40  |
Steve |Name: Steve, Age: 16, Grade: 2.50
16    |
2.50  |
Marry |Name: Marry, Age: 12, Grade: 6.00
12    |
6.00	|

# 2. Passed
Create a program, that receives a single number as an input representing a grade.

Print to the console:
- "Passed!" if the grade is equal or more than 3.00.

**Examples:**

Input| Output|
---  | ---
5.32 |Passed!
2.34 |(no output)

# 3. Passed or Failed
Modify the program from the previous problem, so it will print "Failed!" if the grade is lower than 3.00.

**Input**

The input comes as a single double number.

**Output**

The output is either "Passed!" if the grade is more than 2.99, otherwise you should print "Failed!".

**Examples:**

Input| Output|
---  | ---
5.32 |Passed!
2.34 |Failed!

# 4.	Back in 30 Minutes
Every time John tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes".
One day John was tired of waiting and decided he needs a program, which prints the time after 30 minutes, so could come back after exactly 30 minutes.
He is not able to write the program by himself, so he asks for help.

**Input**

Two numbers are read from the console:
-	The first number is hours and will be between 0 and 23.
-	The second number is minutes and will be between 0 and 59.
-	
**Output**

Print on the console the time after 30 minutes. The result should be in format hh:mm.
The hours may contain one or two numbers and the minutes always have two numbers (with leading zero).

**Examples:**
Input| Output|
---  | ---
1    |2:16
46   |
0    |0:31
01   |
23   |0:29
59   |


# 5.	Month Printer
Create a program that receives an integer and prints the matching month. If the number is more than 12 or less than 1 print "Error!".

**Input**

You will receive a single integer on a single line.

**Output**

If the number is within the boundaries print the corresponding month, otherwise print "Error!".

**Examples:**

Input| Output|
---  | ---
2    |February
13   |Error!

# 6.	Foreign Languages
Create a program that prints the spoken language in a country. You will receive only the following combinations: 
-	English is spoken in England and the USA.
-	Spanish is spoken in Spain, Argentina, and Mexico.
-	For the others, we should print "unknown".
	
**Input**

You will receive a single line of input, representing the country name.

**Output**

Print the language spoken in the given country. If the country is unknown for the program, print "unknown".

**Examples:**

Input| Output|
---  | ---
USA  |English
Germany|unknown

# 7.	Theatre Promotions
A theatre is sail tickets at discount, and a program is needed to calculate the price of a single ticket. 
If the given age does not fit one of the categories, you should print "Error!".  

The prices of the tickers are as follows:

Day / Age|	0 <= age <= 18|	18 < age <= 64|	64 < age <= 122
---|---|---|---|
Weekday|	12$|	18$|	12$
Weekend|	15$|	20$|	15$
Holiday|	5$|	12$|	10$

**Input**

The input comes in two lines. On the first line, you will receive the type of day. On the second – the age of the person.

**Output**

Print the price of the ticket according to the table, or "Error!" if the age is not in the table.

**Constraints**

-	The age will be in the interval [-1000…1000].
-	The type of day will always be valid. 

**Examples:**

Input| Output|
---  | ---
Weekday|18$
42|
Holiday|Error!
-12|
Weekend|15$
122|

# 8.	Divisible by 3
Create a program, which prints all the numbers from 1 to 100, that is divisible by 3. You have to use a single for loop. 
The program should not receive input.

# 9.	Sum of Odd Numbers
Create a program that prints on a new line the next n odd numbers (starting from 1). On the last row prints the sum of all n odd numbers.

**Input**

A single number n is read from the console, indicating how many odd numbers need to be printed.

**Output**

Print the next n odd numbers, starting from 1, separated by newlines. On the last line, print the sum of these numbers.

**Constraints**

-	n will be in the interval [1…100]

**Examples:**

Input|Output
---|---
5  |1
&nbsp;|3
&nbsp;|5
&nbsp;|7
&nbsp;|9
&nbsp;|Sum: 25

# 10.	 Multiplication Table
Create a program that receives an integer as an input. Print the 10 times table for this integer. See the examples below for more information.

**Output**

Print every row of the table in the following format:

{theInteger} X {times} = {product}

**Constraints**

-	The integer will be in the interval [1…100]

**Examples:**

Input|Output
---|---
5  |5 X 1 = 5
&nbsp;|5 X 2 = 10
&nbsp;|5 X 3 = 15
&nbsp;|5 X 4 = 20
&nbsp;|5 X 5 = 25
&nbsp;|5 X 6 = 30
&nbsp;|5 X 7 = 35
&nbsp;|5 X 8 = 40
&nbsp;|5 X 9 = 45
&nbsp;|5 x 10 = 50

 # 11.	Multiplication Table 2.0
 Rewrite the program from the previous task so it can receive the multiplier from the console. Print the table from the given multiplier to 10. 
 If the given multiplier is more than 10 - print only one row with the integer, the given multiplier, and the product. 
 See the examples below for more information.
 
**Output**

Print every row of the table in the following format:

{theInteger} X {times} = {product}

**Constraints**

-	The integer will be in the interval [1…100]

**Examples:**

Input|Output|&nbsp;|Input|Output          
---  |---   | ---   | ---| ---
5    |5 X 1 = 5| &nbsp;|2|2 X 14 = 28
1    |5 X 2 = 10|&nbsp;|14|
&nbsp;|5 X 3 = 15|&nbsp;|
&nbsp;|5 X 4 = 20|&nbsp;|
&nbsp;|5 X 5 = 25|&nbsp;|
&nbsp;|5 X 6 = 30|&nbsp;|
&nbsp;|5 X 7 = 35|&nbsp;|
&nbsp;|5 X 8 = 40|&nbsp;|
&nbsp;|5 X 9 = 45|&nbsp;|
&nbsp;|5 x 10 = 50|&nbsp;|
 
 # 12.	Even Number
 Create a program that reads a sequence of numbers. If the number is even, print its absolute value in the following format:
 
"The number is: {number}", and terminate the program. 
 
If the number is odd, print "Please write an even number." and continue reading numbers.
 
**Examples:**

Input|Output|&nbsp;|Input|Output          
---  |---   | ---   | ---| ---
1    |Please write an even number.|&nbsp;|-6|The number is: 6
3    |Please write an even number.|&nbsp;|
6    |The number is: 6|&nbsp;|
