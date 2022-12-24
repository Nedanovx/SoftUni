# 1.	Ages
Write a program that determines if a person is baby, child, teenager, adult, elder based on the given age. The bounders are:
-	0-2 – baby
-	3-13 – child
-	14-19 – teenager
-	20-65 – adult
- \>= 66 – elder
-	All the values are inclusive.

**Examples:**

Input|	Output
---|---
20|adult
1|baby
100|elder

# 2.	Divison
You will be given an integer, write a program which check if the given integer is divisible by 2, or 3,  or 6,  or 7, or 10 without a reminder.
You should always take the bigger division:
-	If the number is divisible by both 2, 3, and 6, you should print only the division by 6 only. 
-	If a number is divisible by 2 and 10, you should print the division by 10. 

If the number is not divisible by any of the given numbers print "Not divisible". Otherwise, print "The number is divisible by {number}".

**Examples:**

Input|	Output
  ---|---
  30|The number is divisible by 10
  15|The number is divisible by 3
  12|The number is divisible by 6
  1643|Not divisible
  
  # 3.	Vacation
  You will receive three lines from the console:
-	A count of people, which are going on vacation.
-	Type of the group (Students, Business, or Regular).
-	 The day of the week which the group will stay (Friday, Saturday, or Sunday).

Based on the given information calculate how much the group will pay for the entire vacation. 

The price for a single person is as follows:

&nbsp;|Friday|Saturday|Sunday
---|---|---|---
Students|	8.45|	9.80|	10.46
Business|	10.90|	15.60|	16
Regular|	15|	20|	22.50

There are also discounts based on some conditions:
-	For Students, if the group is 30 or more people, you should reduce the total price by 15%
-	For Business, if the group is 100 or more people, 10 of the people stay for free.
-	For Regular, if the group is between 10 and 20  people (both inclusively), reduce the total price by 5%

Note: You should reduce the prices in that EXACT order!

As an output print the final price which the group is going to pay in the format: 

**"Total price: {price}"**

The price should be formatted to the second decimal point.

**Examples:**
Input|Output
---|---
30|Total price: 266.73
Students|
Sunday|
40|Total price: 800.00
Regular|
Saturday|	

# 4.	Print and Sum
You will receive two whole numbers from the console representing the start and the end of a sequence of numbers. 
Your task is to print two lines:
-	On the first line print, all numbers from the start of the sequence to the end inclusive
-	On the second line print the sum of the sequence in the format: "Sum: {sum}"

**Examples:**

Input|Output
---|---
5|5 6 7 8 9 10
10|Sum: 45
&nbsp;|&nbsp;
0|0 1 2 … 26
26|	Sum: 351

# 5.	Login
On the first line, you will be given a username, your task is to try to log in the user. The user’s password is username reversed.
On the next lines, you will receive passwords:
-	If the password is incorrect print "Incorrect password. Try again."
-	If the password is correct print: "User {username} logged in." and stop the program

Keep in mind, on the fourth attempt if the password is still not correct print: "User {username} blocked!"

Then the program stops.

**Examples:**

Input|Output
---|---
Acer|Incorrect password. Try again.
login|Incorrect password. Try again.
go|Incorrect password. Try again.
let me in|User Acer logged in.
recA|
momo|User momo logged in.
omom|
sunny|Incorrect password. Try again.
rainy|Incorrect password. Try again.
cloudy|Incorrect password. Try again.
sunny|User sunny blocked!
not sunny|

# 6.	Strong Number
Write a program that receives a single integer and calculates is it a strong or not.
A number is strong if the sum of the Factorial of each digit is equal to the number. 

Example: 145 is a strong number, because 1! + 4! + 5! = 145. 

Print "yes" if the number is strong or "no" if the number is not strong.

**Examples:**

Input|Output
---|---
2|yes
3451|no
40585|yes

# 7.	Vending Machine
Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated. Valid coins are:
-	0.1, 0.2, 0.5, 1, and 2

If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
On the next lines, until the "End" command is given you will start receiving products, which a customer wants to buy. The vending machine has only:
-	"Nuts" with a price of 2.0
-	"Water" with a price of 0.7
-	"Crisps" with a price of 1.5
-	"Soda" with a price of 0.8
-	"Coke" with a price of 1.0

If the customer tries to purchase a not existing product print "Invalid product".
When a customer has enough money to buy the selected product, print "Purchased {product name}", otherwise print "Sorry, not enough money", and continue to the next line.
When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".

**Examples:**

Input|Output
---|---
1|Cannot accept 0.6
1|Purchased coke
0.5|Purchased soda
0.6|Sorry, not enough money
Start|Change: 0.70
Coke|
Soda|
Crisps|
End|
1|Sorry, not enough money
Start|Purchased coke
Nuts|Change: 0.00
Coke|
End|

# 8.	Triangle of Numbers
Write a program, which receives a number – n, and prints a triangle from 1 to n.

Constraints

•	n will be in the interval [1...20].

**Examples:**

Input|Output    |Input|Output
---|---|        ---|---
3|	1|           5| 1|   
&nbsp;|2 2| &nbsp;|2 2|  
&nbsp;|3 3 3|&nbsp;|3 3 3|			
&nbsp;|&nbsp;|&nbsp;|4 4 4 4|
&nbsp;|&nbsp;|&nbsp;|5 5 5 5 5|
&nbsp;|&nbsp;|&nbsp;|

# 9. Padawan Equipment
Yoda is starting his newly created Jedi academy. So, he asked master John to buy the needed equipment. The number of items depends on how many students will sign up. The equipment for each Padawan contains:
-	Lightsaber
-	Belt
-	Robe

You will be given the amount of money John has, the number of students, and the prices of each item. Calculate does John has enough money to buy equipment for each Padawan, or how much more money he needs.
There are some additional requirements: 
-	Lightsabres sometimes break, so John should buy 10% more (taken from the student's count), rounded up to the next integer
-	Every sixth belt is free

Input / Constraints

The input data should be read from the console. It will consist of exactly 5 lines:
-	The amount of money John has – the floating-point number in the range [0.00…1,000.00]
-	The count of students – integer in the range [0…100]
-	The price of lightsabers for a single saber – the floating-point number in the range [0.00…100.00]
-	The price of robes for a single robe – the floating-point number in the range [0.00…100.00]
-	The price of belts for a single belt – the floating-point number in the range [0.00…100.00]

The input data will always be valid. There is no need to check it explicitly.

**Output**

The output should be printed on the console.
-	If the calculated price of the equipment is less or equal to the money John has:
-	"The money is enough - it would cost {the cost of the equipment}lv."
-	If the calculated price of the equipment is more than the money John has:
-	 " John will need {neededMoney}lv more."
-	All prices must be rounded to two digits after the decimal point.

**Examples:**

Input|Output
---|---
100|The money is enough - it would cost 13.00lv.
2|
1.0|
2.0|
3.0	|
100|John will need 737.00lv more.
42|
12.0|
4.0|
3.0|








