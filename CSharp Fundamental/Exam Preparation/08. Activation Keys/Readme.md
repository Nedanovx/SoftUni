# Activation Keys


You are about to make some good money, but first, you need to think of a way to verify who paid for your product and who didn't.</br>
You have decided to let people use the software for a free trial period and then require an activation key to continue using the product.</br>
Before you can cash out, the last step is to design a program that creates unique activation keys for each user. So, waste no more time and start typing!
The first line of the input will be your raw activation key. It will consist of letters and numbers only. 
After that, until the "Generate" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the raw activation key.

There are several types of instructions, split by ">>>":

- "Contains>>>{substring}":
    - If the raw activation key contains the given substring, prints: "{raw activation key} contains {substring}".
    - Otherwise, prints: "Substring not found!"
    
-	"Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
    - Changes the substring between the given indices (the end index is exclusive) to upper or lower case and then prints the activation key.
    - All given indexes will be valid.
    
-	"Slice>>>{startIndex}>>>{endIndex}":
    - Deletes the characters between the start and end indices (the end index is exclusive) and prints the activation key.
    -	Both indices will be valid.

**Input**
-	The first line of the input will be a string consisting of letters and numbers only. 
-	After the first line, until the "Generate" command is given, you will be receiving strings.

**Output**
•	After the "Generate" command is received, print:
   - "Your activation key is: {activation key}"

**Examples**
<table >
	<tbody>
		<tr>
			<td><b>Input</b></td>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>abcdefghijklmnopqrstuvwxyz</br>
Slice>>>2>>>6</br>
Flip>>>Upper>>>3>>>14</br>
Flip>>>Lower>>>5>>>7</br>
Contains>>>def</br>
Contains>>>deF</br>
Generate
</td>
			<td>abghijklmnopqrstuvwxyz</br>
abgHIJKLMNOPQRstuvwxyz</br>
abgHIjkLMNOPQRstuvwxyz</br>
Substring not found!</br>
Substring not found!</br>
Your activation key is: abgHIjkLMNOPQRstuvwxyz
</td>
		</tr>
	</tbody>
</table>
