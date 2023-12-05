# Problem - Secret Chat

You have plenty of free time, so you decide to write a program that conceals and reveals your received messages. Go ahead and type it in!

On the first line of the input, you will receive the **concealed message**. After that, until the **"Reveal"** command is given, **you will receive strings with instructions for different operations that need to be performed upon the concealed message** to **interpret** it and reveal its actual content. There are several types of instructions, split by ":|:"
-	**"InsertSpace:|:{index}":**
    -	Inserts a single space at the given index. The given index will always be valid.
-	**"Reverse:|:{substring}":**
    -	If the message contains the given substring, cut it out, reverse it and add it at the end of the message. 
    -	If not, print "error".
    -	This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
-	**"ChangeAll:|:{substring}:|:{replacement}":**
    -	Changes all occurrences of the given substring with the replacement text.

**Input / Constraints**
-	On the first line, you will receive a string with a message.
-	On the following lines, you will be receiving commands, split by **":|:"**.

**Output**
-	After each set of instructions, print the resulting string. 
-	After the "Reveal" command is received, print this message:</br>
**"You have a new text message: {message}"**

**Examples**
<table >
	<tbody>
		<tr>
			<td><b>Input</b></td>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>heVVodar!gniV</br>
ChangeAll:|:V:|:l</br>
Reverse:|:!gnil</br>
InsertSpace:|:5</br>
Reveal
</td>
			<td>hellodar!gnil</br>
hellodarling!</br>
hello darling!</br>
You have a new text message: hello darling!
</td>
		</tr>
	</tbody>
</table>
