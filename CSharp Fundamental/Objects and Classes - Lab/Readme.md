# 1.	Randomize Words
You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.

**Examples:**

Input|	Output
---|---
Welcome to SoftUni and have fun learning programming|	learning
||Welcome
||SoftUni
||and
||fun
||programming
||have
||to	

# 2.	Big Factorial
You will receive a number N in the range [0 - 1000]. Calculate the Factorial of N and print out the result.

**Examples:**

Input|	Output
---|---
50	|30414093201713378043612608166064768844377641568960512000000000000
125|	188267717688892609974376770249160085759540364871492425887598231508353156331613598866882932889495923133646
||405445930057740630161919341380597818883457558547055524326375565007131770880000000000000000000000000000000

# 3.	Songs
Define a class called Song that will hold the following information about some songs:
-	Type List
-	Name
-	Time

**Input / Constraints**
-	On the first line, you will receive the number of songs - N.
-	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}"
-	On the last line, you will receive Type List or "all".

**Output**

If you receive Type List as an input on the last line, print out only the names of the songs which are from that Type List. If you receive the "all" command, print out the names of all the songs.

**Examples:**

Input|	Output
---|---
3|DownTown
favourite_DownTown_3:14|Kiss
favourite_Kiss_4:16|Smooth Criminal
favourite_Smooth Criminal_4:01
favourite	
Input|	Output
4|Andalouse
favourite_DownTown_3:14
listenLater_Andalouse_3:24
favourite_In To The Night_3:58
favourite_Live It Up_3:48
listenLater	
Input|	Output
2|Replay
like_Replay_3:15|Photoshop
ban_Photoshop_3:48
all	

# 4.	Students
Define a class called Student, which will hold the following information about some students: 
-	first name
-	last name
-	age
-	home town

**Input / Constraints**

Read information about some students until you receive the "end" command. After that, you will receive a city name.

**Output**

Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."

**Examples:**

Input|	Output
---|---
John Smith 15 Sofia|John Smith is 15 years old.
Peter Ivanov 14 Plovdiv|Linda Bridge is 16 years old.
Linda Bridge 16 Sofia
Simon Stone 12 Varna
end
Sofia	
Input|	Output
Anthony Taylor 15 Chicago|Anthony Taylor is 15 years old.
David Anderson 16 Washington|Jack Lewis is 14 years old.
Jack Lewis 14 Chicago|David Lee is 14 years old.
David Lee 14 Chicago
end
Chicago	

# 5.	Students 2.0
Use the class from the previous problem. If you receive a student, which already exists (first name and last name should be unique) overwrite the information

**Examples:**

Input|	Output
---|---
John Smith 15 Sofia|John Smith is 15 years old.
Peter Johnson 14 Plovdiv|Linda Bridge is 27 years old.
Peter Johnson 25 Plovdiv
Linda Bridge 16 Sofia
Linda Bridge 27 Sofia
Simon Stone 12 Varna
end
Sofia
Input|	Output
Anthony Taylor 15 Chicago|Anthony Taylor is 15 years old.
David Anderson 16 Washington|Jack Lewis is 26 years old.
Jack Lewis 14 Chicago|David Lee is 18 years old.
David Lee 14 Chicago
Jack Lewis 26 Chicago
David Lee 18 Chicago
end
Chicago

# 6.	Store Boxes
Define a class Item, which contains these properties: Name and Price.
Define a class Box, which contains these properties: Serial Number, Item, Item Quantity, and Price for a Box.
Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
The Price of one box has to be calculated: itemQuantity * itemPrice.
Print all the boxes, ordered descending by price for a box, in the following format: 

{boxSerialNumber}

-- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}

-- ${boxPrice}

The price should be formatted to the 2nd digit after the decimal separator.

**Examples:**

Input|	Output
---|---
19861519 Dove 15 2.50|37741865
86757035 Butter 7 3.20|-- Samsung - $1000.00: 10
39393891 Orbit 16 1.60|-- $10000.00
37741865 Samsung 10 1000|19861519
end	|-- Dove - $2.50: 15
||-- $37.50
||39393891
||-- Orbit - $1.60: 16
||-- $25.60
||86757035
||-- Butter - $3.20: 7
||-- $22.40
Input|	Output
48760766 Alcatel 8 100|97617240
97617240 Intel 2 500|-- Intel - $500.00: 2
83840873 Milka 20 2.75|-- $1000.00
35056501 SneakersXL 15 1.50|48760766
end|-- Alcatel - $100.00: 8
||-- $800.00
||83840873
||-- Milka - $2.75: 20
||-- $55.00
||35056501
||-- SneakersXL - $1.50: 15
||-- $22.50














