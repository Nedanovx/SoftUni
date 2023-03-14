# 1. Square Root
Write a program that reads an integer number and calculates and prints its square root.
- If the number is negative, print "Invalid number."
- In all cases finally, print "Goodbye."

Use try-catch-finally.

**Examples:**
Input|Output
---|---
9|3<BR/> Goodbye.
-1|Invalid number.<BR/> Goodbye.

# 2. Enter Numbers
Write a method ReadNumber(int start, int end) that enters an integer number in a given range (start…end), excluding the numbers start and end. <BR/>
If an invalid number or a non-number text is entered, the method should throw an exception. <BR/>
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. <BR/>
If the user enters an invalid number, continue while there are 10 valid numbers entered. Print the array elements, separated with comma and space “, ”.

Hints
- When the entered input holds a non-integer value, print “Invalid Number!”
- When the entered input holds an integer that is out of range, print "Your number is not in range {currentNumber} - 100!"

**Examples:**
Input|Output
---|---
2<BR/>3<BR/>4<BR/>5<BR/>6<BR/>7<BR/>8<BR/>9<BR/>10<BR/>11|2, 3, 4, 5, 6, 7, 8, 9, 10, 11

# 3. Cards
Create a class Card to hold a card’s face and suit.
- Valid card faces are: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
- Valid card suits are: S (♠), H (♥), D (♦), C (♣)

Both face and suit are expected as an uppercase string. The class also needs to have a toString() method that prints the card’s face and suit as a string in the following format:

"[{face}{suit}]" – example: [A♠] [5♣] [10♦]

Use the following UTF code literals to represent the suits:

- \u2660 – Spades (♠)

- \u2665 – Hearts (♥)

- \u2666 – Diamonds (♦)

- \u2663 – Clubs (♣)

Write a program that takes a deck of cards as a string array and prints them as a sequence of cards (space separated). Print an exception message "Invalid card!" when an invalid card definition is passed as input.

**Input**
- A single line with the faces and suits of the cards in the format:

"{face} {suit}, {face} {suit}, …"

**Output**

- As output, print on the console the list of cards as strings, separated by space

**Examples:**

Input|Output
---|---
A S, 10 D, K H, 2 C|[A♠] [10♦] [K♥] [2♣]
5 C, 10 D, king C, K C, Q heart, Q H|Invalid card!<BR/>Invalid card!<BR/>[5♣] [10♦] [K♣] [Q♥]

# 4. Sum of Integers
You will receive a sequence of elements of different types, separated by space. Your task is to calculate the sum of all valid integer numbers in the input. <BR/>
Try to add each element of the array to the sum and write messages for the possible exceptions while processing the element:
- If you receive an element, which is not in the correct format (FormatException): "The element '{element}' is in wrong format!"
- If you receive an element, which is out of the integer type range (OverflowException): "The element '{element}' is out of range!"

After each processed element add the following message:

"Element '{element}' processed - current sum: {sum}"

At the end print the total sum of all integers:

"The total sum of all integers is: {sum}"

**Examples:**

Input|Output
:---|:---
2147483649 2 3.4 5 invalid 24 -4<BR/><BR/><BR/><BR/><BR/><BR/><BR/><BR/><BR/><BR/>|The element '2147483649' is out of range!<BR/> Element '2147483649' processed - current sum: 0<BR/> Element '2' processed - current sum: 2<BR/> The element '3.4' is in wrong format!<BR/> Element '3.4' processed - current sum: 2 <BR/>Element '5' processed - current sum: 7<BR/> The element 'invalid' is in wrong format!<BR/> Element 'invalid' processed - current sum: 7<BR/> Element '24' processed - current sum: 31<BR/> Element '-4' processed - current sum: 27<BR/> The total sum of all integers is: 27
Input|Output
9876 string 10 -2147483649 -8 3 4.86555 8<BR/><BR/><BR/><BR/><BR/><BR/><BR/><BR/><BR/><BR/><BR/>|Element '9876' processed - current sum: 9876<BR/> The element 'string' is in wrong format!<BR/> Element 'string' processed - current sum: 9876<BR/> Element '10' processed - current sum: 9886<BR/> The element '-2147483649' is out of range!<BR/> Element '-2147483649' processed - current sum: 9886<BR/> Element '-8' processed - current sum: 9878<BR/> Element '3' processed - current sum: 9881<BR/> The element '4.86555' is in wrong format!<BR/> Element '4.86555' processed - current sum: 9881<BR/> Element '8' processed - current sum: 9889<BR/> The total sum of all integers is: 9889

# 5. Play Catch
You will receive on the first line an array of integers. After that you will receive commands, which should manipulate the array:
- "Replace {index} {element}" – Replace the element at the given index with the given element.
- "Print {startIndex} {endIndex}" – Print the elements from the start index to the end index inclusive.
- "Show {index}" – Print the element at the index.

You have the task to rewrite the messages from the exceptions which can be produced from your program:
- If you receive an index, which does not exist in the array print: "The index does not exist!"
- If you receive a variable, which is of invalid type: "The variable is not in the correct format!"

When you catch 3 exceptions – stop the input and print the elements of the array separated with ", ".

**Examples:**
Input|Output
:---|:---
1 2 3 4 5<BR/>Replace 1 9<BR/>Replace 6 3<BR/>Show 3<BR/>Show peter<BR/>Show 6|The index does not exist!<BR/> 4<BR/> The variable is not in the correct format!<BR/> The index does not exist!<BR/> 1, 9, 3, 4, 5<BR/>&nbsp;
Input|Output
1 2 3 4 5<BR/>Replace 3 9<BR/>Print 1 4<BR/>Print -3 12<BR/>Print 1 5<BR/>Show 3<BR/>Show 12.3|2, 3, 9, 5<BR/> The index does not exist!<BR/> The index does not exist!<BR/> 9<BR/> The variable is not in the correct format!<BR/> 1, 2, 3, 9, 5<BR/>&nbsp;

**Constraints**
- The elements of the array will be in integers in the interval [-2147483648…2147483647]
- You will always receive a valid string for the first part of the command, but the parameters might be invalid
- In the “Print” command always be true startIndex <= endIndex
- You will always receive at least 3 exceptions

# 6. Money Transactions
You will receive on the first line a collection of bank accounts, consisting of an account number (integer) and its balance (double), in the following format:

"{account number}-{account balance},{account number}-{account balance},…"

After that, until the "End" command, you will receive commands, which should manipulate the given account\`s balance:

- "Deposit {account number} {sum}" – Add the given sum to the given account\`s balance.

- "Withdraw {account number} {sum}" – Subtract the given sum from the account\`s balance.

Print the following messages from the exceptions which can be produced from your program:

- If you receive an invalid command: "Invalid command!"

- If you receive an account, which does not exist: "Invalid account!"

- If you receive the "Withdraw" command with the sum, which is bigger than the balance: "Insufficient balance!"

In all cases, after each received command, print the message:

"Enter another command"

After each successful operation print, the new balance is formatted to the second integer after the decimal point:

"Account {account number} has new balance: {balance}"

**Examples:**

Input|Output
:---|:---
1-45.67,2-3256.09,3-97.34<BR/>Deposit 1 50<BR/>Withdraw 3 100<BR/>End|Account 1 has new balance: 95.67<BR/> Enter another command<BR/> Insufficient balance!<BR/> Enter another command
Input|Output
1473653-97.34,44643345-2347.90<BR/>Withdraw 1473653 150.50<BR/>Deposit 44643345 200<BR/>Block 1473653 30<BR/>Deposit 1 30<BR/>End<BR/>&nbsp;<BR/>&nbsp;|Insufficient balance!<BR/> Enter another command<BR/> Account 44643345 has new balance: 2547.90<BR/> Enter another command<BR/> Invalid command!<BR/> Enter another command<BR/> Invalid account!<BR/> Enter another command
