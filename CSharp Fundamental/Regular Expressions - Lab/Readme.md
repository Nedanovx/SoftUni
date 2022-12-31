# 1.	Match Full Name
Write a C# Program to match full names from a list of names and print them on the console.
Writing the Regular Expression
First, create a regular expression to match a valid full name, according to these conditions:

**A valid full name has the following characteristics:**
-	It consists of two words.
-	Each word starts with a capital letter.
-	After the first letter, it only contains lowercase letters afterward.
-	Each of the two words should be at least two letters long.
-	The two words are separated by a single space.

**Examples:**
Input|Output
---|---
Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam	        Smith |Bethany Taylor John Smith
|||
Elvis Presley a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith B B PETER BROWN IVAN DAVIES-|Elvis Presley Muhammad Ali Michael Jackson

# 2.	Match Phone Number
Create a regular expression to match a valid phone number from Sofia. After you find all valid phones, print them on the console, separated by a comma and a space ", ".
Compose the Regular Expression

A valid number has the following characteristics:
-	It starts with "+359"
-	Then, it is followed by the area code (always 2)
-	After that, it’s followed by the number itself:
-	The number consists of 7 digits (separated into two groups of 3 and 4 digits respectively). 
-	The different parts are separated by either a space or a hyphen ('-').

**Examples:**

Input|Output
---|---
+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222|+359 2 222 2222, +359-2-222-2222
|||
+359 2 234 2324, 359-2-111-9876, +359/8/655/5432, +359-2 222 2222, +359 2-222-2222, +359-2-234-345, +359-2-123-45678, +359-2-222-2222, +359 2 654 1234|+359 2 234 2324, +359-2-222-2222, +359 2 654 1234

# 3.	Match Dates
Write a program, which matches a date in the format "dd{separator}MMM{separator}yyyy". Use named capturing groups in your regular expression.
Compose the Regular Expression
Every valid date has the following characteristics:
-	Always starts with two digits, followed by a separator
-	After that, it has one uppercase and two lowercase letters (e.g. Jan, Mar).
-	After that, it has a separator and exactly 4 digits (for the year).
-	The separator could be either of three things: a period ("."), a hyphen ("-") or a forward-slash ("/")
-	The separator needs to be the same for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is NOT). Use a group backreference to check for this.

**Examples:**

Input|Output
---|---
13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016|Day: 13, Month: Jul, Year: 1928
||Day: 10, Month: Nov, Year: 1934
||Day: 25, Month: Dec, Year: 1937
|||
03-Mar-1878, 25/Apr/1915, 31-May-1916, 22/Jun-1941, 25.Dec.1937, 23/09/1973|Day: 03, Month: Mar, Year: 1878
||Day: 25, Month: Apr, Year: 1915
||Day: 31, Month: May, Year: 1916
||Day: 25, Month: Dec, Year: 1937


