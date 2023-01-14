# 1.	Sum Matrix Elements
Write a program that reads a matrix from the console and prints:
-	Count of rows
-	Count of columns
-	Sum of all matrix elements

On the first line, you will get matrix sizes in format [rows, columns]

**Examples:**
Input|Output
---|---
3, 6|3
7, 1, 3, 3, 2, 1|6
1, 3, 9, 8, 5, 6|76
4, 6, 7, 9, 1, 0

# 2.	Sum Matrix Columns
Create a program that reads a matrix from the console and prints the sum for each column. On the first line, you will get matrix rows. 
On the next rows lines, you will get elements for each column separated with a space. 

**Examples:**
Input|Output|Input|Output
---|---|---|---
3, 6|12|3, 3|12
7 1 3 3 2 1|10|1 2 3|15
1 3 9 8 5 6|19|4 5 6|18
4 6 7 9 1 0|20|7 8 9|
||8
||7

# 3.	Primary Diagonal
Create a program that finds the sum of matrix primary diagonal.
 
**Input**
-	On the first line, you are given the integer N – the size of the square matrix
-	The next N lines hold the values for every row – N numbers separated by a space

**Examples:**
Input|Output|Input|Output
---|---|---|---
3|4|3|15|
11 2 4||1 2 3
4 5 6||4 5 6
10 8 -12||7 8 9

# 4.	Symbol in Matrix
Create a program that reads N, a number representing rows and cols of a matrix. On the next N lines, you will receive rows of the matrix. 
Each row consists of ASCII characters. After that, you will receive a symbol. Find the first occurrence of that symbol in the matrix 
and print its position in the format: "({row}, {col})". If there is no such symbol print an error message  "{symbol} does not occur in the matrix "

**Examples:**
Input|Output|Input|Output
---|---|---|---
3|(2, 1)|4|4 does not occur in the matrix
ABC||asdd
DEF||xczc
X!@||qwee
!||qefw
|||4

# 5.	Square with Maximum Sum
Create a program that reads a matrix from the console. Then find the biggest sum of the 2x2 submatrix and print it to the console.
On the first line, you will get matrix sizes in format rows, columns.
In the lines of One next row, you will get elements for each column separated with a comma.
Print the biggest top-left square, which you find, and the sum of its elements.

**Examples:**
Input|Output|Input|Output
---|---|---|---
3, 6|9 8|2, 4|12 13
7, 1, 3, 3, 2, 1|7 9|10, 11, 12, 13|16 17 
1, 3, 9, 8, 5, 6|33|14, 15, 16, 17|58
4, 6, 7, 9, 1, 0

# 6.	Jagged-Array Modification
Create a program that reads a matrix from the console. On the first line, you will get matrix rows. 

On the next rows lines, you will get elements for each column separated with space. You will be receiving commands in the following format:
-	Add {row} {col} {value} – Increase the number at the given coordinates with the value.
-	Subtract {row} {col} {value} – Decrease the number at the given coordinates by the value.

Coordinates might be invalid. In this case, you should print "Invalid coordinates". When you receive "END" you should print the matrix and stop the program.

**Examples:**
Input|Output|Input|Output
---|---|---|---
3|6 2 3|4|Invalid coordinates
1 2 3|4 3 6|1 2 3 4|Invalid coordinates
4 5 6|7 8 9|5 6 7 8|-41 2 3 4
7 8 9||8 7 6 5|5 6 7 8
Add 0 0 5||4 3 2 1|8 7 6 5
Subtract 1 1 2||Add 4 4 100|4 3 2 101
END||Add 3 3 100|
|||Subtract -1 -1 42
|||Subtract 0 0 42
|||END

# 7.	Pascal Triangle
The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero entry 1. 
Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, 
treating blank entries as 0. For example, the initial number in the first (or any other) row is 1 (the sum of 0 and 1), 
whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.

Print each row element separated with whitespace

**Examples:**
Input|Output|Input|Output
---|---|---|---
4|1|13|1 
||1 1 ||1 1
||1 2 1 ||1 2 1
||1 3 3 1||1 3 3 1
||||1 4 6 4 1 
||||1 5 10 10 5 1 
||||1 6 15 20 15 6 1 
||||1 7 21 35 35 21 7 1 
||||1 8 28 56 70 56 28 8 1 
||||1 9 36 84 126 126 84 36 9 1 
||||1 10 45 120 210 252 210 120 45 10 1 
||||1 11 55 165 330 462 462 330 165 55 11 1 
||||1 12 66 220 495 792 924 792 495 220 66 12 1 

