# 1. Unique Usernames
Create a program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones. <br/>
On the first line, you will be given an integer N. On the next N lines, you will receive one username per line.<br/>
Print the collection on the console in order of insertion:

**Examples:**

<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
6<br/>John<br/>John<br/>John<br/>Peter<br/>John<br/>Boy1234  
</td><td> 
John <br/>Peter<br/>Boy1234 
</td>
  <td>
10<br/>Peter<br/>Maria<br/>Peter<br/>George<br/>Sam<br/>Maria<br/>Sara<br/>Peter<br/>Sam<br/>George
  </td>
  <td>
Peter<br/> Maria<br/> George<br/> Sam<br/> Sara
  </td></tr> </table>
  
# 2. Sets of Elements

Create a program that prints a set of elements. On the first line, you will receive two numbers - n and m, which represent the lengths of two separate sets.<br/>
On the next n + m lines, you will receive n numbers, which are the numbers in the first set, and m numbers, which are in the second set.<br/>
Find all the unique elements that appear in both of them and print them in the order in which they appear in the first set - n.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
4 3<br/>1<br/>3<br/>5<br/>7<br/>3<br/>4<br/>5<br/> 
</td><td> 
3 5
</td>
  <td>
2 2<br/>1<br/>3<br/>1<br/>5<br/>
  </td>
  <td>
1
  </td></tr> </table>

# 3. Periodic Table

Create a program that keeps all the unique chemical elements.<br/>
On the first line, you will be given a number n - the count of input lines that you are going to receive.<br/>
On the next n lines, you will be receiving chemical compounds, separated by a single space. Your task is to print all the unique ones in ascending order:

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
4<br/>Ce O<br/>Mo O Ce<br/>Ee<br/>Mo
</td><td> 
Ce Ee Mo O
</td>
  <td>
3<br/>Ge Ch O Ne<br/>Nb Mo Tc<br/>O Ne
  </td>
  <td>
Ch Ge Mo Nb Ne O Tc
  </td></tr> </table>
  
# 4. Even Times

Create a program that prints a number from a collection, which appears an even number of times in it.<br/>
On the first line, you will be given n – the count of integers you will receive. On the next n lines, you will be receiving the numbers.<br/>
It is guaranteed that only one of them appears an even number of times. Your task is to find that number and print it in the end.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
3<br/>2<br/>-1<br/>2
</td><td> 
2
</td>
  <td>
5<br/>1<br/>2<br/>3<br/>1<br/>5
  </td>
  <td>
1
  </td></tr> </table>
  
# 5. Count Symbols

Create a program that reads some text from the console and counts the occurrences of each character in it. Print the results in alphabetical (lexicographical) order.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
SoftUni rocks
</td><td> 
&nbsp; : 1 time/s<br/> S: 1 time/s<br/> U: 1 time/s<br/> c: 1 time/s<br/> f: 1 time/s<br/> i: 1 time/s<br/> k: 1 time/s<br/> n: 1 time/s<br/> o: 2 time/s<br/> 
r: 1 time/s<br/> s: 1 time/s<br/> t: 1 time/s
</td>
  <td>
Did you know Math.Round rounds to the nearest even integer?
  </td>
  <td>
&nbsp;: 9 time/s<br/> .: 1 time/s<br/> ?: 1 time/s<br/> D: 1 time/s<br/> M: 1 time/s<br/> R: 1 time/s<br/> a: 2 time/s<br/> d: 3 time/s<br/> e: 7 time/s
  </td></tr> </table>
  
# 6. Wardrobe
Create a program that helps you decide what clothes to wear from your wardrobe. You will receive the clothes, which are currently in your wardrobe,<br/>
sorted by their color in the following format:

"{color} -> {item1},{item2},{item3}…"

If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records.<br/>
You can also receive repeating items for a certain color and you have to keep their count.

In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, separated by a space in the following format:

"{color} {clothing}"

Your task is to print all the items and their count for each color in the following format:

"{color} clothes:<br/>
\* {item1} - {count}<br/>
\* {item2} - {count}<br/>
\* {item3} - {count}<br/>


If you find the item you are looking for, you need to print "(found!)" next to it:

"* {itemN} - {count} (found!)"

**Input**

- On the first line, you will receive n - the number of lines of clothes, which you will receive.

- On the next n lines, you will receive the clothes in the format described above.

**Output**

- Print the clothes from your wardrobe in the format described above.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
4<br/>Blue -> dress,jeans,hat<br/>Gold -> dress,t-shirt,boxers<br/>White -> briefs,tanktop<br/>Blue -> gloves<br/>Blue dress
</td><td> 
Blue clothes:<br/> * dress - 1 (found!)<br/> * jeans - 1<br/> * hat - 1<br/> * gloves - 1<br/> Gold clothes:<br/> * dress - 1<br/> * t-shirt - 1<br/>
* boxers - 1<br/> White clothes:<br/> * briefs - 1<br/> * tanktop - 1
</td>
  <td>
4<br/>Red -> hat<br/>Red -> dress,t-shirt,boxers<br/>White -> briefs,tanktop<br/>Blue -> gloves<br/>White tanktop
  </td>
  <td>
Red clothes:<br/> * hat - 1<br/> * dress - 1<br/> * t-shirt - 1<br/> * boxers - 1<br/> White clothes:<br/> * briefs - 1<br/> * tanktop - 1 (found!)<br/>
    Blue clothes:<br/> * gloves - 1
  </td></tr> </table>
  
# 7. The V-Logger

Create a program that keeps the information about vloggers and their followers.<br/>
The input will come as a sequence of strings, where each string will represent a valid command. The commands will be presented in the following format:

* "{vloggername}" joined The V-Logger – keep the vlogger in your records.<br/>
  o Vloggernames consist of only one word.<br/>
  o If the given vloggername already exists, ignore that command.

* "{vloggername} followed {vloggername}" – The first vlogger followed the second vlogger.<br/>
  o If any of the given vlogernames does not exist in your collection, ignore that command.<br/>
  o Vlogger cannot follow himself.<br/>
  o Vloggers cannot follow someone he is already a follower of.

* "Statistics" - Upon receiving this command, you have to print a statistic about the vloggers.

Each vlogger has a unique vloggername. Vloggers can follow other vloggers and a vlogger can follow as many other vloggers as he wants,<br/>
but he cannot follow himself or follow someone he is already a follower of. You need to print the total count of vloggers in your collection.<br/>
Then you have to print the most famous vlogger – the one with the most followers, with his followers. If more than one vloggers have the same number of followers,<br/>
print the one following fewer people, and his followers should be printed in lexicographical order<br/>
(in case the vlogger has no followers, print just the first line, which is described below). Lastly, print the rest of the vloggers, <br/>
ordered by the count of followers in descending order, then by the number of vloggers he follows in ascending order. The whole output must be in the following format:

"The V-Logger has a total of {registered vloggers} vloggers in its logs.

1. {mostFamousVlogger} : {followers} followers, {followings} following

\* {follower1}

\* {follower2} …

{No}. {vlogger} : {followers} followers, {followings} following

{No}. {vlogger} : {followers} followers, {followings} following…"

**Input**

- The input will come in the format described above.

**Output**

- On the first line, print the total count of vloggers in the format described above.

- On the second line print the most famous vlogger in the format described above.

- On the next lines, print all of the rest vloggers in the format described above.

**Constraints**

- There will be no invalid input.

- There will be no situation where two vloggers have an equal count of followers and equal count of followings.

- Allowed time/memory: 100ms/16MB.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
EmilConrad joined The V-Logger<br/>VenomTheDoctor joined The V-Logger<br/>Saffrona joined The V-Logger<br/>Saffrona followed EmilConrad<br/>
Saffrona followed VenomTheDoctor<br/>EmilConrad followed VenomTheDoctor<br/>VenomTheDoctor followed VenomTheDoctor<br/>Saffrona followed EmilConrad<br/> Statistics
</td><td> 
The V-Logger has a total of 3 vloggers in its logs.<br/> 1. VenomTheDoctor : 2 followers, 0 following<br/> * EmilConrad<br/> * Saffrona<br/> 
2. EmilConrad : 1 followers, 1 following<br/> 3. Saffrona : 0 followers, 2 following
</td>
  <td>
JennaMarbles joined The V-Logger<br/>JennaMarbles followed Zoella<br/> AmazingPhil joined The V-Logger<br/> JennaMarbles followed AmazingPhil<br/> 
Zoella joined The V-Logger<br/> JennaMarbles followed Zoella<br/> Zoella followed AmazingPhil<br/> Christy followed Zoella<br/> Zoella followed Christy<br/> 
JacksGap joined The V-Logger<br/> JacksGap followed JennaMarbles<br/> PewDiePie joined The V-Logger<br/> Zoella joined The V-Logger<br/> Statistics
  </td>
  <td>
The V-Logger has a total of 5 vloggers in its logs.<br/> 1. AmazingPhil : 2 followers, 0 following<br/> * JennaMarbles<br/> * Zoella<br/>
2. Zoella : 1 followers, 1 following<br/> 3. JennaMarbles : 1 followers, 2 following<br/> 4. PewDiePie : 0 followers, 0 following<br/>
5. JacksGap : 0 followers, 1 following
  </td></tr> </table>
  
# 8. *Ranking

Create a program that ranks candidate-interns, depending on the points from the interview tasks and their exam results in SoftUni.<br/>
You will receive some lines of input in the format "{contest}:{password for contest}" until you receive "end of contests".<br/>
Save that data because you will need it later. After that you will receive another type of inputs in the format: 

"{contest}=>\{password\}=>\{username\}=>\{points\}" 

until you receive "end of submissions". Here is what you need to do:
- Check if the contest is valid (if you received it in the first type of input).
- Check if the password is correct for the given contest.
- Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest.<br/>
-  If you receive the same contest and the same user, update the points only if the new ones are more than the older ones.

At the end you have to print the info for the user with the most points in the format:

"Best candidate is \{user\} with total \{total points\} points."<br/> After that print all students ordered by their names. 
For each user, print each contest with the points in descending order in the following format:

"{user1 name}

\# {contest1} -> {points}

\# {contest2} -> {points}

{user2 name}

…"

**Input**
· You will be receiving strings in the formats described above, until the appropriate commands, also described above, are given.

**Output**
- On the first line, print the best user in the format described above.
- On the next lines, print all students ordered as mentioned above in format.

**Constraints**
- There will be no case with two equal contests.
- The strings may contain any ASCII character except (:, =, >).
- The numbers will be in the range [0…10000].
- The second input is always valid.
- There will be no case with 2 or more users with the same total points.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
Part One Interview:success<br/>Js Fundamentals:JSFundPass<br/>C# Fundamentals:fundPass<br/>Algorithms:fun<br/>end of contests<br/>
C# Fundamentals=>fundPass=>Tanya=>350<br/>Algorithms=>fun=>Tanya=>380<br/>Part One<br/>Interview=>success=>Nikola=>120<br/>Java Basics<br/>
Exam=>JSFundPass=>Parker=>400<br/>Part One Interview=>success=>Tanya=>220<br/>OOP Advanced=>password123=>BaiIvan=>231<br/>C# Fundamentals=>fundPass=>Tanya=>250<br/>
C# Fundamentals=>fundPass=>Nikola=>200<br/>Js Fundamentals=>JSFundPass=>Tanya=>400<br/>end of submissions
</td><td> 
Best candidate is Tanya with total 1350 points.<br/> Ranking:<br/> Nikola<br/> #&nbsp; C# Fundamentals -> 200<br/> #&nbsp; Part One Interview -> 120<br/>
Tanya<br/> #&nbsp; Js Fundamentals -> 400<br/> #&nbsp;  Algorithms -> 380<br/> # &nbsp; C# Fundamentals -> 350<br/> #&nbsp;  Part One Interview -> 220
</td>
  <td>
Java Advanced:funpass<br/>Part Two Interview:success<br/>Math Concept:asdasd<br/>Java Web Basics:forrF<br/>end of contests<br/>Math Concept=>ispass=>Monika=>290<br/>
Java Advanced=>funpass=>Simon=>400<br/>Part Two Interview=>success=>Drago=>120<br/>Java Advanced=>funpass=>Petyr=>90<br/>Java Web Basics=>forrF=>Simon=>280<br/>
Part Two Interview=>success=>Petyr=>0<br/>Math Concept=>asdasd=>Drago=>250<br/>Part Two Interview=>success=>Simon=>200
  </td>
  <td>
Best candidate is Simon with total 880 points.<br/> Ranking:<br/> Drago<br/> #&nbsp;  Math Concept -> 250<br/> #&nbsp;  Part Two Interview -> 120<br/> Petyr<br/> 
#&nbsp; Java Advanced -> 90<br/> #&nbsp; Part Two Interview -> 0<br/> Simon<br/> #&nbsp; Java Advanced -> 400<br/> #&nbsp; Java Web Basics -> 280<br/>
    #&nbsp; Part Two Interview -> 200
  </td></tr> </table>
  
# 9. SoftUni Exam Results
Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. 
You should collect all the submissions and print the final results and statistics about each language that the participants submitted their solutions in.

You will be receiving lines in the following format: "{username}-{language}-{points}", until you receive "exam finished". 
You should store each username and his submissions and points. You can receive a command to ban a user for cheating in the following format:<br/> 
"{username}-banned".<br/> 
In that case, you should remove the user from the contest, but preserve his submissions in the total count of submissions for each language.

After receiving "exam finished" print each of the participants, ordered descending by their max points, then by username, in the following format:

"Results:"

"{username} | {points}"

…

After that print each language, used in the exam, ordered descending by total submission count and then by language name, in the following format:

"Submissions:"

"{language} – {submissionsCount}"

…

**Input / Constraints**

Until you receive "exam finished" you will be receiving participant submissions in the following format: "{username}-{language}-{points}".

You can receive a ban command -> "{username}-banned"

The points of the participant will always be a valid integer in the range [0-100];

**Output**

- Print the exam results for each participant, ordered descending by max points and then by username, in the following format:

"Results:"

"{username} | {points}"

…

- After that print each language, ordered descending by total submissions and then by language name, in the following format:

"Submissions:"

"{language} – {submissionsCount}"

…

- Allowed working time / memory: 100ms / 16MB.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
Peter-Java-84<br/>George-C#-70<br/>George-C#-84<br/>Sam-C#-94<br/>exam finished
</td><td> 
Results:<br/> Sam | 94<br/> George | 84<br/> Peter | 84<br/> Submissions:<br/> C# - 3<br/> Java - 1
</td>
  <td>
Peter-Java-91<br/>George-C#-84<br/>Sam-JavaScript-90<br/>Sam-C#-50<br/>Sam-banned<br/>exam finished
  </td>
  <td>
Results:<br/> Peter | 91<br/> George | 84<br/> Submissions:<br/> C# - 2<br/> Java - 1<br/> JavaScript - 1
  </td></tr> </table>
  
# 10. ForceBook
The force users are struggling to remember which side is the different forceUsers from, because they switch them too often. 
So you are tasked to create a web application to manage their profiles. You should store an information for every unique forceUser, registered in the application.

You will receive several input lines in one of the following formats:

{forceSide} | {forceUser}

{forceUser} -> {forceSide}

The forceUser and forceSide are strings, containing any character.

If you receive forceSide | forceUser, you should check if such forceUser already exists, and if not, add him/her to the corresponding side.

If you receive a forceUser -> forceSide, you should check if there is such a forceUser already and if so, change his/her side. If there is no such forceUser, add him/her to the corresponding forceSide, treating the command as a newly registered forceUser. Then you should print on the console: "{forceUser} joins the {forceSide} side!".

You should end your program when you receive the command "Lumpawaroo". At that point, you should print each force side, ordered descending by forceUsers count then ordered by name. For each side print the forceUsers, ordered by name.

In case there are no forceUsers in the side, you shouldn\`t

**Constraints**
- The input comes in the form of commands in one of the formats specified above.
- The input ends, when you receive the command "Lumpawaroo".

**Output**
- As output for each forceSide, ordered descending by forceUsers count, then by name, you must print all the forceUsers, ordered by name alphabetically.
- The output format is:

"Side: {forceSide}, Members: {forceUsers.Count}"

"! {forceUser}"

"! {forceUser}"

"! {forceUser}"

- In case there are NO forceUsers, don\`t print this side.

**Examples:**
<table>
<tr>
<th>Input</th>
<th>Output</th>
<th>Input</th>
<th>Output</th>
</tr>
<tr>
<td>  
Light | George<br/>Dark | Peter<br/>Lumpawaroo
</td><td> 
Side: Dark, Members: 1<br/> ! Peter<br/> Side: Light, Members: 1<br/> ! George
</td>
  <td>
Lighter | Royal<br/>Darker | DCay<br/>John Johnys -> Lighter<br/>DCay -> Lighter<br/>Lumpawarood
  </td>
  <td>
John Johnys joins the Lighter side!<br/> DCay joins the Lighter side!<br/> Side: Lighter, Members: 3<br/> ! DCay<br/> ! John Johnys<br/> ! Royal
  </td></tr> </table>
