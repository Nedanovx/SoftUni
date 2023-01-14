# 1.	Basic Stack Operations
Play around with a stack. You will be given an integer N representing the number of elements to push into the stack, 
an integer S representing the number of elements to pop from the stack, and finally an integer X, an element that you should look for in the stack. 
If it’s found, print "true" on the console. If it isn't, print the smallest element currently present in the stack. If there are no elements in the sequence, 
print 0 on the console.

**Input**
-	On the first line, you will be given N, S, and X, separated by a single space
-	On the next line, you will be given N number of integers

**Output**
-	On a single line print either true if X is present in the stack, otherwise print the smallest element in the stack. If the stack is empty, print 0

**Examples:**

Input|Output|Input|Output
---|---|---|---
5 2 13|true|4 1 666|13
1 13 45 32 4||420 69 13 666

# 2.	Basic Queue Operations
Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add), 
an integer S representing the number of elements to dequeue (remove) from the queue, and finally an integer X, an element that you should look for in the queue. 
If it is, print true on the console. If it’s not printed the smallest element is currently present in the queue. If there are no elements in the sequence, 
print 0 on the console.

**Examples:**

Input|Output|Input|Output
---|---|---|---
5 2 32|true|4 1 666|13
1 13 45 32 4||666 69 13 420

# 3.	Maximum and Minimum Element
You have an empty sequence, and you will be given N queries. Each query is one of these three types: 

1 x – Push the element x into the stack.

2 – Delete the element present at the top of the stack.

3 – Print the maximum element in the stack.

4 – Print the minimum element in the stack.

After you go through all of the queries, print the stack in the following format: "{n}, {n1}, {n2} …, {nn}"

**Input**
-	The first line of input contains an integer, N
-	The next N lines each contain an above-mentioned query. (It is guaranteed that each query is valid)

**Output**
-	For each type 3 or 4 queries, print the maximum/minimum element in the stack on a new line

**Constraints**
-	1 ≤ N ≤ 105
-	1 ≤ x ≤ 109
-	1 ≤ type ≤ 4
-	If there are no elements in the stack, don’t print anything on commands 3 and 4

**Examples:**

Input|Output|Input|Output
---|---|---|---
9|26|10|32
1 97|20|2|66
2|91, 20, 26|1 47|8
1 20||1 66|8, 16, 25, 32, 66, 47
2||1 32
1 26||4
1 20||3
3||1 25
1 91||1 16
4||1 8
|||4

# 4.	Fast Food
You have a fast-food restaurant and most of the food that you're offering is previously prepared. 
You need to know if you will have enough food to serve lunch to all of your customers. Write a program that checks the orders’ quantity. 
You also want to know the client with the biggest order for the day, because you want to give him a discount the next time he comes. 
First, you will be given the quantity of the food that you have for the day (an integer number).  Next, you will be given a sequence of integers, 
each representing the quantity of order. Keep the orders in a queue. Find the biggest order and print it. 
You will begin servicing your clients from the first one that came. Before each order, check if you have enough food left to complete it. 

If you have, remove the order from the queue and reduce the amount of food you have. If you succeeded in servicing all of your clients, print: 
"Orders complete".

If not, print:
"Orders left: {order1} {order2} .... {orderN}".

**Input**
-	On the first line, you will be given the quantity of your food - an integer in the range [0, 1000]
-	On the second line, you will receive a sequence of integers, representing each order, separated by a single space

**Output**
-	Print the quantity of the biggest order
-	Print "Orders complete" if the orders are complete
-	If there are orders left, print them in the format given above

**Constraints**
-	The input will always be valid

**Examples:**

Input|Output|Input|Output
---|---|---|---
348|54|499|90
20 54 30 16 7 9|Orders complete|57 45 62 70 33 90 88 76|Orders left: 76

# 5.	Fashion Boutique
You own a fashion boutique and you receive a delivery once a month in a huge box, which is full of clothes. You have to arrange them in your store, 
so you take the box and start from the last piece of clothing on the top of the pile to the first one at the bottom. Use a stack for this purpose. 
Each piece of clothing has its value (an integer). You have to sum their values, while you take them out of the box. 
You will be given an integer representing the capacity of a rack. While the sum of the clothes is less than the capacity, keep summing them. 
If the sum becomes equal to the capacity you have to take a new rack for the next clothes if there are any left in the box. If it becomes greater than the capacity, 
don't add the piece of clothing to the current rack and take a new one. In the end, print how many racks you have used to hang all of the clothes.

**Input**
-	On the first line, you will be given a sequence of integers, representing the clothes in the box, separated by a single space
-	On the second line, you will be given an integer, representing the capacity of a rack

**Output**
-	Print the number of racks, needed to hang all of the clothes from the box

**Constraints**
-	The values of the clothes will be integers in the range [0,20]
-	There will never be more than 50 clothes in a box
-	The capacity will be an integer in the range [0,20]
-	None of the integers from the box will be greater than than the value of the capacity

**Examples:**

Input|Output|Input|Output
---|---|---|---
5 4 8 6 3 8 7 7 9|5|1 7 8 2 5 4 7 8 9 6 3 2 5 4 6|5
16||20

# 6.	Songs Queue
Write a program that keeps track of a song's queue. The first song that is put in the queue, should be the first that gets played. 
A song cannot be added if it is currently in the queue.
You will be given a sequence of songs, separated by a comma and a single space. After that, you will be given commands until there are no songs enqueued.
When there are no more songs in the queue print "No more songs!" and stop the program.

The possible commands are:
-	"Play" - plays a song (removes it from the queue)
-	"Add {song}" - adds the song to the queue if it isn’t contained already, otherwise print "{song} is already contained!"
-	"Show" - prints all songs in the queue separated by a comma and a white space (start from the first song in the queue to the last)

**Input**
-	On the first line, you will be given a sequence of strings, separated by a comma and a white space
-	On the next lines, you will be given commands until there are no songs in the queue

**Output**
-	While receiving the commands, print the proper messages described above
-	After the command "Show", print the songs from the first to the last

**Constraints**
-	The input will always be valid and in the formats described above
-	There might be commands even after there are no songs in the queue (ignore them)
-	There will never be duplicate songs in the initial queue

**Examples:**

Input|Output
---|---
All Over Again, Watch Me|Watch Me is already contained!
Play|Watch Me, Love Me Harder, Promises
Add Watch Me|No more songs!
Add Love Me Harder
Add Promises
Show
Play
Play
Play
Play

# 7.	Truck Tour
Suppose there is a circle. There are N petrol pumps on that circle. Petrol pumps are numbered 0 to (N−1) (both inclusive). 
You have two pieces of information corresponding to each of the petrol pumps: (1) the amount of petrol that particular petrol pump will give, 
and (2) the distance from that petrol pump to the next petrol pump.
Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at any of the petrol pumps. 
Calculate the first point from where the truck will be able to complete the circle. Consider that the truck will stop at each of the petrol pumps. 
The truck will move one kilometer for each liter of petrol.

**Input**
-	The first line will contain the value of N
-	The next N lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between 
that petrol pump and the next petrol pump

**Output**
-	An integer which will be the smallest index of the petrol pump from which we can start the tour

**Constraints**
-	1 ≤ N ≤ 1000001
-	1 ≤ Amount of petrol, Distance ≤ 1000000000

**Examples:**

Input|Output
---|---
3|1
1 5
10 3
3 4

# 8.	Balanced Parentheses
Given a sequence consisting of parentheses, determine whether the expression is balanced. 
A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closing parenthesis that occurs after the former. 
Also, the interval between them must be balanced. You will be given three types of parentheses: (, {, and [.

{[()]} - This is a balanced parenthesis.

{[(])} - This is not a balanced parenthesis.

**Input**
-	Each input consists of a single line, the sequence of parentheses.

**Output**
-	For each test case, print on a new line "YES" if the parentheses are balanced. 
Otherwise, print "NO". Do not print the quotes.

**Constraints**
-	1 ≤ lens ≤ 1000, where the lens is the length of the sequence.
-	Each character of the sequence will be one of {, }, (, ), [, ].

**Examples:**

Input|Output|Input|Output
---|---|---|---
{[()]}|YES|{[(])}|NO

# 9.	Simple Text Editor
You are given an empty text. Your task is to implement 4 commands related to manipulating the text
-	1 someString - appends someString to the end of the text
-	2 count - erases the last count elements from the text
-	3 index - returns the element at position index from the text
-	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation

**Input**
-	The first line contains n, the number of operations.
-	Each of the following n lines contains the name of the operation followed by the command argument, if any, 
separated by space in the following format "CommandName Argument".

**Output**
•	For each operation of type 3 print a single line with the returned character of that operation.

**Constraints**
-	1 ≤ N ≤ 105
-	The length of the text will not exceed 1000000
-	All input characters are English letters.
-	It is guaranteed that the sequence of input operations is possible to perform.

**Examples:**

Input|Output
---|---
8|c
1 abc|y
3 3|a
2 3
1 xy
3 2
4
4 
3 1

# 10.	Crossroads
Our favorite super-spy action hero Sam is back from his mission in the previous exam, and he has finally found some time to go on a holiday. 
He is taking his wife somewhere nice and they’re going to have a really good time, but first, they have to get there. Even on his holiday trip, 
Sam is still going to run into some problems and the first one is, of course, getting to the airport. 
Right now, he is stuck in a traffic jam at a very active crossroads where a lot of accidents happen.
Your job is to keep track of traffic at the crossroads and report whether a crash happened or everyone passed the crossroads safely and our hero is one step closer
to a much-desired vacation.
The road Sam is on has a single lane where cars queue up until the light goes green.
When it does, they start passing one by one during the green light and the free window before the intersecting road’s light goes green. 
During one second only one part of a car (a single character) passes the crossroads. If a car is still at the crossroads when the free window ends, 
it will get hit at the first character that is still in the crossroads.

**Input**
-	On the first line, you will receive the duration of the green light in seconds – an integer in the range [1-100]
-	On the second line, you will receive the duration of the free window in seconds – an integer in the range [0-100]
-	On the following lines, until you receive the "END" command, you will receive one of two things:
  *	A car – a string containing any ASCII character, or
  *	The command "green" indicates the start of a green light cycle

A green light cycle goes as follows:
-	During the green light, cars will enter and exit the crossroads one by one
-	During the free window, cars will only exit the crossroads

**Output**
-	If a crash happens, end the program and print:

"A crash happened!"

"{car} was hit at {characterHit}."

-	If everything goes smoothly and you receive an "END" command, print:

"Everyone is safe."

"{totalCarsPassed} total cars passed the crossroads."

**Constraints**
•	The input will be within the constraints specified above and will always be valid. There is no need to check it explicitly.

**Examples:**
Input|Output|Input|Output
---|---|---|---|
10|Everyone is safe.|9|A crash happened!
5|3 total cars passed the crossroads.|3|Hummer was hit at e.
Mercedes||Mercedes|
green||Hummer|
Mercedes||green
BMW||green|
Skoda||Hummer
green||Mercedes
END||green
|||END



















