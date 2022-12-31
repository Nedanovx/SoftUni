# 1.	Furniture
Create a program to calculate the total cost of different types of furniture. You will be given some lines of input until you receive the line "Purchase".
For the line to be valid it should be in the following format: ">>{furniture name}<<{price}!{quantity}"

The price can be a floating-point number or a whole number. Store the names of the furniture and the total price. 
At the end print each bought furniture on a separate line in the format: 

"Bought furniture:

{1st name}

{2nd name}
…"

And on the last line print, the following: "Total money spend: {spend money}" formatted to the second decimal point.

**Examples:**

Input|Output|Input|Output
---|---|---|---
\>>Sofa<<312.23!3|Bought furniture:|>>Chair<<412.23!3|Bought furniture:
\>>TV<<300!5|Sofa|>>Sofa<<500!5|Chair
\>Invalid<<!5|TV|>>Recliner<<<<!5|Sofa
Purchase|Total money spend: 2436.69|>>Bench<<230!10|Bench
|||>>>>>>Rocking chair<<!5|Bed|
|||>>Bed<<700!5|Total money spend: 9536.69
|||Purchase

# 2.	Race
Write a program that processes information about a race. On the first line, you will be given a list of participants separated by ", ". 
On the next few lines until you receive a line "end of the race" you will be given some info which will be some alphanumeric characters. 
In between them, you could have some extra characters which you should ignore. For example: "G!32e%o7r#32g$235@!2e". 
The letters are the name of the person and the sum of the digits is the distance he ran. So here we have George who ran 29 km. 
Store the information about the person only if the list of racers contains the name of the person. 

If you receive the same person more than once just add the distance to his old distance. At the end print the top 3 racers in the format:

"1st place: {first racer}

2nd place: {second racer}

3rd place: {third racer}"

**Examples:**

Input|Output|Input|Output
---|---|---|---
George, Peter, Bill, Tom|1st place: George|Ivan, Peter, James, Kyle|1st place: Ivan
G4e@55or%6g6!68e!!@|2nd place: Peter|I4v@43an%66?77!!@|2nd place: Peter
R1@!3a$y4456@|3rd place: Tom|G1@!3u$s445s6@|3rd place: James
B5@i@#123ll||B3@i@#245ll|
G@e54o$r6ge#||I&v54a%66n@|
7P%et^#e5346r||7P%et^#e5346r|
T$o553m&6||J$a553m&e6s|
end of race||K2y3=l/^e23|
|||end of race|

# 3.	SoftUni Bar Income
Let's take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the person 
who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a line with the text "end of shift"
you will be given lines of input. But before processing that line you have to do some validations first.

Each valid order should have a customer, product, count, and a price:
-	A valid customer's name should be surrounded by '%' and must start with a capital letter, followed by lower-case letters
-	A valid product contains any word character and must be surrounded by '<' and '>' 
-	A valid count is an integer, surrounded by '|'
-	A valid price is any real number followed by '$'

The parts of a valid order should appear in the order given: customer, product, count, and price.
Between each part there can be other symbols, except ('|', '$', '%' and '.')
For each valid line print on the console: "{customerName}: {product} - {totalPrice}"
When you receive "end of shift" print the total amount of money for the day rounded to 2 decimal places in the following format: "Total income: {income}".

**Input / Constraints**
-	Strings that you have to process until you receive text "end of shift".

**Output**
-	Print all of the valid lines in the format "{customerName}: {product} - {totalPrice}"
-	After receiving "end of shift" print the total amount of money for the day rounded to 2 decimal places in the following format: "Total income: {income}"
-	Allowed working time / memory: 100ms / 16MB.

**Examples:**

Input|Output|Input|Output
---|---|---|---
%George%<Croissant>\|2\|10.3$|George: Croissant - 20.60|%InvalidName%<Croissant>\|2\|10.3$|Valid: Valid - 200.00
%Peter%<Gum>\|1\|1.3$|Peter: Gum - 1.30|%Peter%<Gum>1.3$|Total income: 200.00
%Maria%<Cola>\|1\|2.4$|Maria: Cola - 2.40|%Maria%<Cola>\|1\|2.4|
end of shift|Total income: 24.30|%Valid%<Valid>valid\|10\|valid20$|
|||end of shift|

# 4.	Star Enigma
The war is at its peak, but you, young Padawan, can turn the tides with your programming skills. You are tasked to create a program to decrypt the messages
  of The Order and prevent the death of hundreds of lives. 
You will receive several messages, which are encrypted using the legendary star enigma. You should decrypt the messages, following these rules:
To properly decrypt a message, you should count all the letters [s, t, a, r] – case insensitive and remove the count from the current ASCII value of each symbol 
  of the encrypted message. 
  After decryption:
  Each message should have a planet name, population, attack type ('A', as an attack or 'D', as destruction), and soldier count.
The planet name starts after '@' and contains only letters from the Latin alphabet. 
The planet population starts after ':' and is an Integer;
The attack type may be "A"(attack) or "D"(destruction) and must be surrounded by "!" (exclamation mark).
The soldier count starts after "->" and should be an Integer.
The order in the message should be: planet name -> planet population -> attack type -> soldier count. Each part can be separated from the others by any character except: '@', '-', '!', ':' and '>'.

**Input / Constraints**
-	The first line holds n – the number of messages– integer in the range [1…100];
-	On the next n lines, you will be receiving encrypted messages.

**Output**
After decrypting all messages, you should print the decrypted information in the following format:
First print the attacked planets, then the destroyed planets.

  "Attacked planets: {attackedPlanetsCount}"

  "-> {planetName}"

  "Destroyed planets: {destroyedPlanetsCount}"

  "-> {planetName}"

  The planets should be ordered by name alphabetically.

  **Examples:**

Input|Output|Input|Output
---|---|---|---
2|Attacked planets: 1|3|Attacked planets: 0
STCDoghudd4=63333$D$0A53333|-> Alderaa|tt(''DGsvywgerx>6444444444%H%1B9444|Destroyed planets: 2
EHfsytsnhf?8555&I&2C9555SR|Destroyed planets: 1|GQhrr\|A977777(H(TTTT|-> Cantonica
||-> Cantonica|EHfsytsnhf?8555&I&2C9555SR|-> Coruscant


