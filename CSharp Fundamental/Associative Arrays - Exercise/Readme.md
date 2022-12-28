# 1.	Count Chars in a String
Create a program that counts all characters in a string, except for space (' '). 

Print all the occurrences in the following format: "{char} -> {occurrences}"

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
text|	t -> 2|text text text|t -> 6
||e -> 1||e -> 3
||x -> 1||x -> 3

# 2.	A Miner Task
You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) 
and every even - quantity. Your task is to collect the resources and print them each on a new line.

Print the resources and their quantities in the following format: "{resource} –> {quantity}"

The quantities will be in the range [1… 2 000000000].

**Examples:**

Input|	Output|		Input|	Output
---|---|---|---
Gold|Gold -> 155|gold|gold -> 170
155|Silver -> 10|155|silver -> 10
Silver|Copper -> 17|silver|copper -> 17
10||155
Copper||silver
17||10
stop||copper
|||17
|||gold
|||15
|||stop	

# 3.	Orders
Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity. If the product doesn't exist yet, add it with its starting quantity.
If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.

You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", 
keep adding items. When you do receive the command "buy", print the items with their names and the total price of all the products with that name.

**Input**
-	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
-	The product data is always delimited by a single space.

**Output**
-	Print information about each product in the following format:  "{productName} -> {totalPrice}"
-	Format the average grade to the 2nd digit after the decimal separator.

**Examples:**

Input|Output|Input|Output
---|---|---|---
Beer 2.20 100|Beer -> 220.00|Beer 2.40 350|Beer -> 660.00
IceTea 1.50 50|IceTea -> 75.00|Water 1.25 200|Water -> 250.00
NukaCola 3.30 80|NukaCola -> 264.00|IceTea 5.20 100|IceTea -> 110.00
Water 1.00 500|Water -> 500.00|Beer 1.20 200
buy||IceTea 0.50 120
|||buy|

# 4.	SoftUni Parking
SoftUni just got a new parking lot. It's so fancy, it even has online parking validation. Except the online service doesn't work. 
It can only receive users' data, but it doesn't know what to do with it. Good thing you're on the dev team and know how to fix it, right?
Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.

The program receives 2 commands:	
-	"register {username} {licensePlateNumber}":
	
\-	The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print: 
	
  "ERROR: already registered with plate number {licensePlateNumber}"
  
\-	If the aforementioned checks passes successfully, the plate can be registered, so the system should print: "{username} registered {licensePlateNumber} successfully"
-	"unregister {username}":

\-	If the user is not present in the database, the system should print:
"ERROR: user {username} not found"

\-	If the aforementioned check passes successfully, the system should print:
"{username} unregistered successfully"

After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
\-	"{username} => {licensePlateNumber}"

**Input**
-	First line: n - number of commands – integer.
-	Next n lines: commands in one of the two possible formats:
-	Register: "register {username} {licensePlateNumber}"
-	Unregister: "unregister {username}"

The input will always be valid and you do not need to check it explicitly.

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
5|John registered CS1234JS successfully|4|Jony registered AA4132BB successfully
register John CS1234JS|George registered JAVA123S successfully|register Jony AA4132BB|ERROR: already registered with plate number AA4132BB
register George JAVA123S|Andy registered AB4142CD successfully|register Jony AA4132BB|Linda registered AA9999BB successfully
register Andy AB4142CD|Jesica registered VR1223EE successfully|register Linda AA9999BB|Jony unregistered successfully
register Jesica VR1223EE|Andy unregistered successfully|unregister Jony|Linda => AA9999BB
unregister Andy|John => CS1234JS
||George => JAVA123S
||Jesica => VR1223EE


# 5.	Courses
Create a program that keeps the information about courses. Each course has a name and registered students.
You will be receiving a course name and a student name, until you receive the command "end". Check if such a course already exists, and if not, add the course. 
Register the user into the course. When you receive the command "end", print the courses with their names and total registered users. 
For each contest print the registered users.

**Input**
-	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
-	The product data is always delimited by " : ".

**Output**
-	Print the information about each course in the following the format: "{courseName}: {registeredStudents}"
-	Print the information about each student in the following the format: "-- {studentName}"

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
Programming Fundamentals : John Smith|Programming Fundamentals: 2| Algorithms : Jay Moore|Algorithms: 2
Programming Fundamentals : Linda Johnson|-- John Smith|Programming Basics : Martin Taylor|-- Jay Moore
JS Core : Will Wilson|-- Linda Johnson|Python Fundamentals : John Anderson|-- Bob Jackson
Java Advanced : Harrison White|JS Core: 1|Python Fundamentals : Andrew Robinson|Programming Basics: 1
end|-- Will Wilson|Algorithms : Bob Jackson|-- Martin Taylor
||Java Advanced: 1|Python Fundamentals : Clark Lewis|Python Fundamentals: 3
||-- Harrison White|end|-- John Anderson
||||-- Andrew Robinson
||||-- Clark Lewis

# 6.	Student Academy
Create a program that keeps the information about students and their grades. 
You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade. 
Check if the student already exists and if not, add him. Keep track of all grades for each student.

When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.

Print the students and their average grade in the following format: "{name} –> {averageGrade}"

Format the average grade to the 2nd decimal place.

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
5|John -> 5.00|5|Rob -> 5.50
John|Alice -> 4.50|Amanda|Christian -> 5.00
5.5|George -> 5.00|3.5|Robert -> 6.00
John||Amanda
4.5||4
Alice||Rob
6||5.5
Alice||Christian
3||5
George||Robert
5||6

# 7.	Company Users
Create a program that keeps information about companies and their employees. 
You will be receiving a company name and an employee's id, until you receive the "End" command. Add each employee to the given company.

Keep in mind that a company cannot have two employees with the same id.

When you finish reading the data, print the company's name and each employee's id in the following format:

{companyName}
-- {id1}
-- {id2}
-- {idN}

**Input / Constraints**
-	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
-	The input always will be valid.

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
SoftUni -> AA12345|SoftUni|SoftUni -> AA12345|Movement -> DD11111
SoftUni -> BB12345|-- AA12345|SoftUni -> CC12344|-- AA12345
Microsoft -> CC12345|-- BB12345|Lenovo -> XX23456|-- CC12344
HP -> BB12345|Microsoft|SoftUni -> AA12345|Lenovo
End	|-- CC12345|Movement -> DD11111|-- XX23456
||HP|End|Movement
||-- BB12345||-- DD11111




















