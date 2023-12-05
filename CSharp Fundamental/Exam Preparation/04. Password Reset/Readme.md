# Problem - Password Reset

Yet again, you have forgotten your password. Naturally, it's not the first time this has happened.</br>
Actually, you got so tired of it that you decided to help yourself with an intelligent solution.</br>
Write a password reset program that performs a series of commands upon a predefined string.</br>
First, you will receive a string, and afterward, until the command "Done" is given, you will be receiving strings with commands split by a single space.</br>
The commands will be the following:

-	**"TakeOdd"**
-	 Takes only the characters at odd indices and concatenates them to obtain the new raw password and then prints it.
    -	**"Cut {index} {length}"**
    -	Gets the substring with the given length starting from the given index from the password and removes its first occurrence, then prints the password on the console.
    -	The given index and the length will always be valid.
-	**"Substitute {substring} {substitute}"**
    -	If the raw password contains the given substring, replace all of its occurrences with the substitute text given and print the result.
    -	If it doesn't, prints "Nothing to replace!".

**Input**
-	You will be receiving strings until the "Done" command is given.

**Output**
-	After the "Done" command is received, print:
    -	**"Your password is: {password}"**
	
**Constraints**
-	The indexes from the "Cut {index} {length}" command will always be valid.

**Examples**
<table >
	<tbody>
		<tr>
			<td><b>Input</b></td>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>up8rgoyg3r1atmlmpiunagt!-irs7!1fgulnnnqy</br>
TakeOdd</br>
Cut 18 2</br>
Substitute ! ***</br>
Substitute ? .!.</br>
Done
</td>
			<td>programming!is!funny</br>
programming!is!fun</br>
programming***is***fun</br>
Nothing to replace!</br>
Your password is: programming***is***fun
</td>
		</tr>
	</tbody>
</table>
