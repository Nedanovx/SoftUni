# 1. Sort Numbers
Create a program that receives three real numbers and sorts them in descending order. Print each number on a new line.

**Examples:**

Input|Output|&nbsp;|Input|Output|&nbsp;|Input|Output
---|---|---|---|---|---|---|---
2|3|&nbsp;|-2|3|&nbsp;|0|2
1|2|&nbsp;|1|1|&nbsp;|0|0
3|1|&nbsp;|3|-2|&nbsp;|2|0

# 2. English Name of the Last Digit
Create a method that returns the English spelling of the last digit of a given number.
Write a program that reads an integer and prints the returned value from this method.

**Examples:**

Input|Output
---|---|
512|two
1|one
1643|three

# 3. Gaming Store
Create a program, which helps you buy the games. The valid games are the following games in this table:

Name|Price
---|---
OutFall 4|$39.99
CS: OG|$15.99
Zplinter Zell|	$19.99
Honored 2|	$59.99
RoverWatch|	$29.99
RoverWatch Origins Edition|	$39.99

On the first line, you will receive your current balance – a floating-point number in the range [0.00…5000.00].
Until you receive the command "Game Time", you have to keep buying games. When a game is bought, the user’s balance decreases by the price of the game.
Additionally, the program should obey the following conditions:
-	If a game the user is trying to buy is not present in the table above, print "Not Found" and read the next line.
-	If at any point, the user has $0 left, print "Out of money!" and end the program.
-	Alternatively, if the user is trying to buy a game that they can’t afford, print "Too Expensive" and read the next line.
-	If the game exists and the player has the money for it, print "Bought {nameOfGame}"
When you receive "Game Time", print the user’s remaining money and total spent on games, rounded to the 2nd decimal place.

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
120|Bought RoverWatch|19.99|Not Found
RoverWatch|Bought Honored 2|Reimen origin|Too Expensive
Honored 2|Total spent: $89.98. Remaining: $30.02|RoverWatch|Bought Zplinter Zell
Game Time|&nbsp;|Zplinter Zell|Out of money!
&nbsp;|&nbsp;|Game Time

# 4. Reverse String
Create a program which reverses a string and print it on the console.

**Examples:**

Input|	Output
---|---
Hello|	olleH
SoftUni|	inUtfoS
1234|	4321

# 5. Messages
Create a program, which emulates typing an SMS, following this guide:
1|2 abc|3 def
---|---|---
4 ghi|5 jkl|6 mno
7 pqrs|8 tuv|9 wxyz
&nbsp;|0 space|&nbsp; 

Following the guide, 2 becomes “a”, 22 becomes “b” and so on.

**Examples:**

Input|Output|Input|Output|Input|Output
---|---|---|---|---|---
5|hello|9|hey there|7|meet me
44|&nbsp;|44|&nbsp;|6|
33|&nbsp;|33|&nbsp;|33|
555|&nbsp;|999|&nbsp;|33|
555|&nbsp;|0|&nbsp;|8|
666|&nbsp;|8|&nbsp;|0|
&nbsp;|&nbsp;|44|&nbsp;|6|
&nbsp;|&nbsp;|33|&nbsp;|33|
&nbsp;|&nbsp;|777|&nbsp;|&nbsp;|
&nbsp;|&nbsp;|33|&nbsp;|&nbsp;|








