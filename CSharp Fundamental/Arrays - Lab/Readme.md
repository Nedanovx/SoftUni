# 1.	Day of Week
Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.

**Examples:**

Input|Output
---|---
1|	Monday
2	|Wednesday
10|	Invalid day!

# 2.	Print Numbers in Reverse Order
Read n numbers and print them in reverse order, separated by a single space.

**Examples:**

Input|Output|Input|Output|Input|Output
---|---|---|---|---|---
3|30 20 10|3|10 20 30|1|10
10||30||10|
20||20|
30||10|

# 3.	Rounding Numbers
Read an array of real numbers (space separated), round them in "away from 0" style, and print the output as in the examples:

**Examples:**

Input|Output|Input|Output
---|---|---|---
0.9 1.5 2.4 2.5 3.14|0.9 => 1|-5.01 -1.599 -2.5 -1.50 0|-5.01 -1.599 -2.5 -1.50 0
||1.5 => 2||-1.599 => -2
||2.4 => 2||-2.5 => -3
||2.5 => 3||-1.50 => -2
||3.14 => 3||0 => 0

# 4.	Reverse Array of Strings
Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence of space-separated Strings. 
Print the output on a single line (space separated).

**Examples:**

Input|	Output
---|---
a b c d e|	e d c b a
-1 hi ho w|	w ho hi -1

# 5.	Sum Even Numbers
Read an array from the console and sum only its even values. 

**Examples:**

Input	|Output
---|---
1 2 3 4 5 6|12
3 5 7 9	|0
2 4 6 8 10|30

# 6.	Even and Odd Subtraction
Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.

**Examples:**

Input|Output
---|---
1 2 3 4 5 6|	3	
3 5 7 9|	-24	
2 4 6 8 10| 30	

# 7.	Equal Arrays
Read two arrays and determine whether they are identical or not. The arrays are identical if all their elements are equal. 
If the arrays are identical find the sum of the elements of one of them and print the following message to the console: "Arrays are identical. Sum: {sum}"
Otherwise, find the first index where the arrays differ and print the following message to the console:  "Arrays are not identical. Found difference at {index} index."

**Examples:**

Input     |Output                       |Input     |Output
---       |---                          |---       |---
10 20 30  |Arrays are identical. Sum: 60|1 2 3 4 5|Arrays are not identical. Found difference at 2 index
10 20 30  |                             |1 2 4 3 5|

# 8.	Condense Array to Number
Create a program to read an array of integers and condense them by summing all adjacent couples of elements until a single integer remains.
For example, let us say we have 3 elements - {2, 10, 3}. We sum the first two and the second two elements and get {2 + 10, 10 + 3} = {12, 13}, 
then we sum all adjacent elements again. This results in {12 + 13} = {25}.

**Examples**

Input|Output
---|---
10|25
2|
3|
||
5 0 4 1 2|35
||
