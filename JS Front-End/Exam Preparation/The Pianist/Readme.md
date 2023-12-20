# Problem - The Pianist

You are a pianist, and you like to keep a list of your favorite piano pieces. Create a program to help you organize it and add, change, remove pieces from it!
On the first line of the standard input, you will receive an integer n – the number of pieces you will initially have. On the next n lines, the pieces themselves will follow with their composer and key, separated by "|" in the following format: "{piece}|{composer}|{key}".
Then, you will be receiving different commands, each on a new line, separated by "|", until the "Stop" command is given:
-	**"Add|{piece}|{composer}|{key}":**
    -	You need to add the given piece with the information about it to the other pieces and print:</br>
**"{piece} by {composer} in {key} added to the collection!"**
    -	If the piece is already in the collection, print:</br>
**"{piece} is already in the collection!"**
-	"**Remove|{piece}":**
    -	If the piece is in the collection, remove it and print:</br>
**"Successfully removed {piece}!"**
-	**Otherwise, print:**</br>
"Invalid operation! {piece} does not exist in the collection."
-	**"ChangeKey|{piece}|{new key}":**
-	If the piece is in the collection, change its key with the given one and print:</br>
**"Changed the key of {piece} to {new key}!"**
    -	**Otherwise, print:**</br>
**"Invalid operation! {piece} does not exist in the collection."**

Upon receiving the "Stop" command, you need to print all pieces in your collection in the following format:</br>
**"{Piece} -> Composer: {composer}, Key: {key}"**

<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>[</br>
  '3',</br>
  'Fur Elise|Beethoven|A Minor',</br>
  'Moonlight Sonata|Beethoven|C# Minor',</br>
  'Clair de Lune|Debussy|C# Minor',</br>
  'Add|Sonata No.2|Chopin|B Minor',</br>
  'Add|Hungarian Rhapsody No.2|Liszt|C# Minor',</br>
  'Add|Fur Elise|Beethoven|C# Minor',</br>
  'Remove|Clair de Lune',</br>
  'ChangeKey|Moonlight Sonata|C# Major',</br>
  'Stop'  </br>
]
</td>
			<td>Sonata No.2 by Chopin in B Minor added to the collection!</br>
Hungarian Rhapsody No.2 by Liszt in C# Minor added to the collection!</br>
Fur Elise is already in the collection!</br>
Successfully removed Clair de Lune!</br>
Changed the key of Moonlight Sonata to C# Major!</br>
Fur Elise -> Composer: Beethoven, Key: A Minor</br>
Moonlight Sonata -> Composer: Beethoven, Key: C# Major</br>
Sonata No.2 -> Composer: Chopin, Key: B Minor</br>
Hungarian Rhapsody No.2 -> Composer: Liszt, Key: C# Minor</br>
</td>
		</tr>
	</tbody>
</table>
