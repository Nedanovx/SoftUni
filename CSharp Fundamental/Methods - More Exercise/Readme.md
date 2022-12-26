# 1.	Data Types
Write a program that, depending on the first line of the input, reads an int, double, or string.
-	If the data type is int, multiply the number by 2.
-	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
-	If the data type is a string, surround the input with "$".

Print the result on the console.

**Examples:**

Input|Output
---|---
int|10
5|	
real|3.00
2	|
string|\$ hello \$
hello	|

# 2.	Center Point
You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2, and Y2. Create a method that prints the point that is 
closest to the center of the coordinate system (0, 0) in the format (X, Y). If the points are at the same distance from the center, print only the first one.

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
2|(-1, 2)|3|(3, -6)
4||-6|
-1||2|
2	||10|

# 3.	Longer Line
You are given the coordinates of four points in the 2D plane. The first and the second pair of points form two different lines. 
Print the longer line in the format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the coordinate system (0, 0) 
(You can reuse the method that you wrote for the previous problem). If the lines are of equal length, print only the first one.

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
2|(4, -3)(-5, -5)|34|(5, 9)(34, -3)
4||-3|
-1||5|
2||9|
-5||-8|
-5||10|
4||8|
-3||11|

# 4.	Tribonacci Sequence
In the "Tribonacci" sequence, every number is formed by the sum of the previous 3.
You are given a number num. Write a program that prints num numbers from the Tribonacci sequence, each on a new line, starting from 1. 
The input comes as a parameter named num. The value num will always be a positive integer.

**Examples:**

Input|	Output	|	Input|	Output
---|---|---|---
4|	1 1 2 4|8|	1 1 2 4 7 13 24 44
	

# 5.	Multiplication Sign
You are given a number num1, num2, and num3. Write a program that finds if num1 * num2 * num3 (the product) is negative, positive, or zero. 
Try to do this WITHOUT multiplying the 3 numbers.

**Examples:**

Input	|Output	|	Input|	Output
---|---|---|---
2|negative|2|positive
3||3|
-1||1|
		



