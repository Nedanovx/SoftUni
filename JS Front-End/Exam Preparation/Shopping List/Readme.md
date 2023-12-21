#Problem - Shopping List
It's the end of the week, and it is time for you to go shopping, so you need to create a shopping list first.

**Input**

You will receive an initial list with groceries separated by an exclamation mark "!".</br>
After that, you will be receiving 4 types of commands until you receive "Go Shopping!".
-	"Urgent {item}" - add the item at the start of the list.  If the item already exists, skip this command.
-	"Unnecessary {item}" - remove the item with the given name, only if it exists in the list. Otherwise, skip this command.
-	"Correct {oldItem} {newItem}" - if the item with the given old name exists, change its name with the new one. Otherwise, skip this command.
-	"Rearrange {item}" - if the grocery exists in the list, remove it from its current position and add it at the end of the list. Otherwise, skip this command.

<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>(["Milk!Pepper!Salt!Water!Banana",</br>
"Urgent Salt",</br>
"Unnecessary Grapes",</br>
"Correct Pepper Onion",</br>
"Rearrange Grapes",</br>
"Correct Tomatoes Potatoes",</br>
"Go Shopping!"])
</td>
			<td>Milk, Onion, Salt, Water, Banana</br>
  &nbsp;</br>
  &nbsp;</br>
  &nbsp;</br>
  &nbsp;</br>
 &nbsp;</br>
  &nbsp;</br></td>
		</tr>
	</tbody>
</table>
