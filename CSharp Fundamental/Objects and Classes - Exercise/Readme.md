# 1.	Advertisement Message
Create a program that generates random fake advertisement messages to advertise a product. The messages must consist of 4 parts: 
phrase + event + author + city. Use the following predefined parts:
-	Phrases – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."}
-	Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
-	Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
-	Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}

The format of the output message is the following: "{phrase} {event} {author} – {city}."

You will receive the number of messages to be generated. Print each random message at a separate line.

**Examples:**

Input|	Output
---|---
3|	Such a great product. Now I feel good. Elena – Ruse.
||Excellent product. Makes miracles. I am happy of the results! Katya – Varna.
||Best product of its category. That makes miracles. Eva – Sofia.

# 2.	Articles
Create a class Article with the following properties:
-	Title – a string
-	Content – a string
-	Author – a string

The class should have a constructor and the following methods:
-	Edit (new content) – change the old content with the new one
-	ChangeAuthor (new author) – change the author
-	Rename (new title) – change the title of the article
-	Override the ToString method – print the article in the following format: 
"{title} - {content}: {author}"

Create a program that reads an article in the following format "{title}, {content}, {author}". On the next line, you will receive a number n, representing the number of commands, which will follow after it. On the next n lines, you will be receiving the following commands: 
-	"Edit: {new content}"
-	"ChangeAuthor: {new author}"
-	"Rename: {new title}"

In the end, print the final state of the article.

**Examples:**

Input|	Output
---|---
some title, some content, some author|	better title - better content: better author
3
Edit: better content
ChangeAuthor:  better author
Rename: better title
Input|	Output
Fight club, love story, Martin Scorsese|Fight club - underground fight club that evolves into much more: Chuck Palahniuk
2
Edit: underground fight club that evolves into much more
ChangeAuthor: Chuck Palahniuk	

# 3.	Articles 2.0
Change the program in such a way, that you will be able to store a list of articles. 
You will not need to use the previous methods anymore (except the "ToString()"). On the first line, you will receive the number of articles.
On the next lines, you will receive the articles in the same format as in the previous problem: "{title}, {content}, {author}". 
Finally, you will receive a string: "title", "content" or an "author". Print the articles. 

**Examples:**

Input|	Output
---|---
2|Science - planets: Bill 
Science, planets, Bill|Article - content: Johnny
Article, content, Johnny|
title
Input|	Output
3|title1 - C: author1
title1, C, author1|title2 - B: author2
title2, B, author2|title3 - A: author3
title3, A, author3
content

# 4.	Students
Create a program that sorts some students by their grade in descending order. Each student should have:
-	First name (String)
-	Last name (String)
-	Grade (a floating-point number)

**Input**
-	On the first line, you will receive a number n - the count of all students
-	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}"

**Output**
-	Print out the information about each student in the following format: "{first name} {second name}: {grade}"

**Examples:**

Input|	Output|Input|	Output
---|---|---|---
4|Rocco Erben: 6.00|3|Li Xiao: 5.74
Lakia Eason 3.90|Prince Messing: 5.49|Mary Elizabeth 4.22|Liz Smith: 4.87
Prince Messing 5.49|Akiko Segers: 4.85|Li Xiao 5.74|Mary Elizabeth: 4.22
Akiko Segers 4.85|Lakia Eason: 3.90|Liz Smith 4.87
Rocco Erben 6.00|

# 5.	Teamwork Projects
It's time for the teamwork projects and you are responsible for gathering the teams. First,
you will receive an integer - the count of the teams you will have to register. You will be given a user and a team, separated with "-".  
The user is the creator of the team. For every newly created team you should print a message: 
"Team {teamName} has been created by {user}!".
Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team. Upon receiving the command: "end of assignment", you should print every team, ordered by the count of its members (descending) and then by name (ascending). For each team, you have to print its members sorted by name (ascending). However, there are several rules:
*	If а user tries to create a team more than once, a message should be displayed: 

\- "Team {teamName} was already created!"

*	A creator of a team cannot create another team – the following message should be thrown: 

\-	"{user} cannot create another team!"

*	If а user tries to join a non-existent team, a message should be displayed: 

\-	"Team {teamName} does not exist!"

*	A member of a team cannot join another team – the following message should be thrown:

\- "Member {user} cannot join team {team Name}!"

*	In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order. 
*	 Every valid team should be printed ordered by name (ascending) in the following format:

"{teamName}

\- {creator}
 
-- {member}…"

**Examples:**

Input|	Output
---|---
2|Team PowerPuffsCoders has been created by John!
John-PowerPuffsCoders|Team Tony is the best has been created by Tony!
Tony-Tony is the best|Member Tony cannot join team Tony is the best!
Peter->PowerPuffsCoders|PowerPuffsCoders
Tony->Tony is the best|- John
end of assignment|-- Peter
||Teams to disband:
||Tony is the best

# 6.	Vehicle Catalogue
Until you receive the "End" command, you will be receiving lines of input in the following format:

"{typeOfVehicle} {model} {color} {horsepower}"

After When you receive the "End" command, you will start receiving information about some vehicles.

For every vehicle, print out the information about it in the following format:

"Type: {typeOfVehicle}

Model: {modelOfVehicle}

Color: {colorOfVehicle}

Horsepower: {horsepowerOfVehicle}"

When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the average horsepower of the trucks in the format:
"{typeOfVehicles} have average horsepower of {averageHorsepower}."
The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by the total count of all vehicles from that type. 

Format the answer to the second digit after the decimal point.

**Constraints**
-	The type of vehicle will always be either a car or a truck.
-	You will not receive the same model twice.
-	The received horsepower will be an integer in the range [1…1000]
-	You will receive at most 50 vehicles.
-	The separator will always be single whitespace.

**Examples:**

Input|	Output |                                 Input|	Output
---|---|                                              ---|---
truck Man red 200|Type: Car|truck Volvo blue 220|Type: Car
truck Mercedes blue 300|Model: Ferrari|truck Man red 350|Model: Tesla
car Ford green 120|Color: red|car Tesla silver 450|Color: silver
car Ferrari red 550|Horsepower: 550|car Nio red 650|Horsepower: 450
car Lamborghini orange 570|Type: Car|truck Mack white 430|Type: Car
End|Model: Ford|car Koenigsegg orange 750|Model: Nio
Ferrari|Color: green|End|Color: red
Ford|Horsepower: 120|Tesla|Horsepower: 650
Man|Type: Truck|Nio|Type: Truck
Close the Catalogue|Model: Man|Man|Model: Man
||Color: red|Mack|Color: red
||Horsepower: 200|Close the Catalogue|Horsepower: 350
||Cars have average horsepower of: 413.33.||Type: Truck
||Trucks have average horsepower of: 250.00.||Model: Mack
||||Color: white
||||Horsepower: 430
||||Cars have average horsepower of: 616.67.







