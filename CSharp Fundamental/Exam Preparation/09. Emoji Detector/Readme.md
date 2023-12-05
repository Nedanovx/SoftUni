Problem - Emoji Detector

Your task is to write a program that extracts emojis from a text and find the threshold based on the input.
You have to get your cool threshold. It is obtained by multiplying all the digits found in the input.  The cool threshold could be a huge number, so be mindful.

An emoji is valid when:
-	It is surrounded by 2 characters, either "::" or "**"
-	It is at least 3 characters long (without the surrounding symbols)
-	It starts with a capital letter
-	Continues with lowercase letters only
Examples of valid emojis: ${\color{green}::Joy::}$, ${\color{green}\*\*Banana\*\*}$, ${\color{green}::Wink::}$</br>
Examples of invalid emojis: ${\color{red}::Joy\*\*}$, ${\color{red}::fox:es:}$, ${\color{red}\*\*Monk3ys\*\*}$ , ${\color{red}:Snak::Es::}$</br>
You need to count all valid emojis in the text and calculate their coolness. The coolness of the emoji is determined by summing all the ASCII values of all letters in the emoji. 

Examples: :: ${\color{green}Joy}$ :: - 306, \*\* ${\color{green}Banana}$ \*\* - 577, :: ${\color{green}Wink}$ :: - 409

You need to print the result of the cool threshold and, after that take all emojis out of the text, count them and print only the cool ones on the console.

**Input**
-	On the single input, you will receive a piece of string. 

**Output**
-	On the first line of the output, print the obtained Cool threshold in the format:</br>
"Cool threshold: {coolThresholdSum}"</br>
-	On the following line, print the count of all emojis found in the text in the format:</br>
"{countOfAllEmojis} emojis found in the text. The cool ones are:</br>
{cool emoji 1}</br>
{cool emoji 2}</br>
…</br>
{cool emoji N}"

**Constraints**
There will always be at least one digit in the text!

**Examples**
<table >
	<tbody>
		<tr>
			<td><b>Input</b></td>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>In the Sofia Zoo there are ${\color{yellow}311}$ animals in total!</br>
      ${\color{green}::Smiley::}$ This includes ${\color{yellow}3}$ ${\color{green}**Tigers**}$, ${\color{yellow}1}$ ${\color{red}::Elephant:}$,</br>
  ${\color{yellow}12}$ ${\color{red}**Monk3ys**}$, a ${\color{red}**Gorilla::}$, ${\color{yellow}5}$ ${\color{red}::fox:es:}$ and ${\color{yellow}21}$</br>
  different types of ${\color{red}:Snak::Es::}$. ${\color{green}::Mooning::}$ ${\color{green}**Shy**}$</td>
			<td>Cool threshold: ${\color{yellow}540}$</br>
          ${\color{green}311}$ emojis found in the text.</br> 
  The cool ones are:</br>
${\color{blue}::Smiley::}$</br> 
${\color{blue}**Tigers**}$</br> 
${\color{blue}::Mooning::}$
</td>
		</tr>
	</tbody>
</table>
