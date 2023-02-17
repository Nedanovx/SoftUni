# 1. ListyIterator
Create a generic class ListyIterator. The collection, which it will iterate through, should be received by the constructor.
You should store the elements in a List. The class should have three main functions:
- Move - should move an internal index position to the next index in the list. The method should return true, if it had successfully moved the index and false, if there is no next index.
- HasNext - should return true, if there is a next index and false, if the index is already at the last element of the list.
- Print - should print the element at the current internal index. Calling Print on a collection without elements should throw an appropriate exception with the message "Invalid Operation!".

By default, the internal index should be pointing to the 0th index of the List. Your program should support the following commands:
<table >
	<tbody>
		<tr>
			<td>Command </td>
			<td>Return Type </td>
			<td>Description </td>
		</tr>
		<tr>
			<td>Create {e1 e2 …} </td>
			<td>void </td>
			<td>Creates a ListyIterator from the specified collection. <br/>
        In case of a Create command without any elements, <br/>you should create a ListyIterator with an empty collection. </td>
		</tr>
		<tr>
			<td>Move </td>
			<td> Boolean</td>
			<td> This command should move the internal index to the next index.</td>
		</tr>
		<tr>
			<td>Print </td>
			<td>void </td>
			<td>This command should print the element at the current internal index </td>
		</tr>
		<tr>
			<td>HasNext </td>
			<td>boolean </td>
			<td>Returns whether the collection has the next element. </td>
		</tr>
		<tr>
			<td>END </td>
			<td>void </td>
			<td> Stops the input.</td>
		</tr>
	</tbody>
</table>

Your program should catch any exceptions thrown because of the described validations - calling Print on an empty collection - and print their messages instead.

**Input**
- Input will come from the console as lines of commands.
- The first line will always be the Create command in the input.
- The last command received will always be the END command.

**Output**
- For every command from the input (except for the END and Create commands), print the result of that command on the console, each on a new line.
- In the case of Move or HasNext commands, print the return value of the methods.
- In the case of a Print command, you don't have to do anything additional as the method itself should already print on the console.

**Constraints**
- There will always be only one Create command and it will always be the first command passed.
- The number of commands received will be between [1…100].
- The last command will always be the only END command.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Create<br/>Print<br/>END </td>
			<td>Invalid Operation! </td>
		</tr>
		<tr>
			<td>Create Steve George<br/>HasNext<br/>Print<br/>Move<br/>Print<br/>END </td>
			<td> True<br/>Steve<br/>True<br/> George</td>
		</tr>
	</tbody>
</table>

# 2. Collection

Using the ListyIterator from the last problem, extend it by implementing the IEnumerable<T> interface, implement all methods desired by the interface manually. Use yield return for the GetEnumerator() method. Add a new command PrintAll that should foreach the collection and print all of the elements on a single line separated by a space. Your program should catch any exceptions thrown because of validations and print their messages instead.

**Input**
- Input will come from the console as lines of commands.
- The first line will always be the Create command in the input.
- The last command received will always be the END command.

**Output**
- For every command from the input (except for the END and Create commands), print the result of that command on the console, each on a new line.
- In the case of Move or HasNext commands print the return value of the method.
- In the case of a Print command, you don't have to do anything additional as the method itself should already print on the console.
- In the case of a PrintAll command, you should print all of the elements on a single line separated by spaces.

**Constraints**
- Do NOT use the GetEnumerator() method from the base class. Use your implementation using "yield return".
- There will always be only one Create command and it will always be the first command passed.
- The number of commands received will be between [1…100].
- The last command will always be the only END command.

**Examples:**
  <table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Create 1 2 3 4 5<br/>Move<br/>PrintAll<br/>END </td>
			<td>True<br/> 1 2 3 4 5 </td>
		</tr>
		<tr>
			<td>Create Stefcho Goshky Peshu<br/>PrintAll<br/>Move<br/>Move<br/>Print<br/>HasNext<br/>END </td>
			<td>Stefcho Goshky Peshu<br/> True<br/> True<br/> Peshu<br/> False</td>
		</tr>
	</tbody>
</table>
  
  # 3. Stack
Create your custom stack. You are aware of Stack's structure. 
  There is a collection to store the elements and two functions (not from the functional programming) - to push an element and to pop it. 
  Keep in mind that the first element, which is popped is the last in the collection. 
  The Push method adds an element at the top of the collection and the Pop method returns the top element and removes it. 
  Push and Pop will be the only commands and they will come in the following format:

"Push {element1}, {element2}, … {elementN}

Pop

… "

Write your custom implementation of Stack<T> and implement IEnumerable<T> interface.<br/>Your implementation of the GetEnumerator() method should follow the rules of the Abstract Data Type – Stack (return the elements in reverse order of adding them to the stack).

**Input**
- The input will come from the console as lines of commands.
- Push and Pop will be the only possible commands, followed by integers for the Push command and no other input for the Pop command.

**Output**
- When you receive END, the input is over. Foreach the stack twice and print all elements each on the new line.

**Constraints**
- The elements in the push command will be valid integers between [2-31…231-1].
- The commands will always be valid (always be either Push, Pop, or END).
- If the Pop command could not be executed as expected (e.g. no elements in the stack), print on the console: "No elements".
  
  **Examples:**
  <table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Push 1, 2, 3, 4<br/>Pop<br/>Pop<br/>END </td>
			<td>2<br/>1<br/>2<br/>1</td>
		</tr>
		<tr>
			<td>Push 1, 2, 3, 4<br/>Pop<br/>Pop<br/>Pop<br/>Pop<br/>${\color{red}Pop}$<br/>END</td>
			<td>${\color{red}No \space elements}$</td>
		</tr>
	</tbody>
</table>
  
  # 4. Froggy
Let's play a game. You have a tiny little Frog and a Lake that has a path of stones in it. Every stone has a number. 
  Our frog must cross the lake along that path and then return. But there are some rules. First, the frog must jump on all the stones, 
  which are in even positions in ascending order, and then on all the odd ones, but in reversed order. 
  The order of the stones and their numbers will be given on the first line of input. 
  Then you must print the order of stones in which our frog jumped from one to another.

Try to achieve this functionality by creating a class Lake (it will hold all stone numbers in order) that implements the IEnumerable<int> interface and overrides its GetEnumerator() methods.
  
  **Examples:**
  <table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>${\color{red}1}$, ${\color{yellow}2}$, ${\color{red}3}$, ${\color{yellow}4}$, ${\color{red}5}$, ${\color{yellow}6}$, ${\color{red}7}$, ${\color{yellow}8}$</td>
			<td>${\color{red}1}$, ${\color{red}3}$, ${\color{red}5}$, ${\color{red}7}$, ${\color{yellow}8}$, ${\color{yellow}6}$, ${\color{yellow}4}$, ${\color{yellow}2}$</td>
		</tr>
		<tr>
			<td>${\color{red}1}$, ${\color{yellow}2}$, ${\color{red}3}$, ${\color{yellow}4}$, ${\color{red}5}$ </td>
			<td>${\color{red}1}$, ${\color{red}3}$, ${\color{red}5}$, ${\color{yellow}4}$, ${\color{yellow}2}$ </td>
		</tr>
	</tbody>
</table>
  
  # 5. Comparing Objects
Create a class Person. Each person should have a name, an age and a town. You should implement the interface – IComparable<T> and implement the CompareTo method. When you compare two people, first you should compare their names, after that – their age and finally – their towns. You will be receiving input with information about the people until you receive the "END" command in the following format:

"{name} {age} {town}"

After that, you will receive n – the n'th person from your collection, starting from 1. You should keep statistics how many people are equal to him, how many people are not equal to him, and the total people in your collection in the following format:

"{count of matches} {number of not equal people} {total number of people}"

If there are no equal people print: "No matches".

**Input**
- You will be receiving lines in the format described above, until the "END" command.
- After the "END" command, you will receive the position of the person you should compare the others to.

Note: Start counting the people in your collection from 1.

**Output**
- Print a single line of output in the format described above.

**Constraints**
- Input names, ages and addresses will be valid.
- Input number will always be а valid integer in the range [2…100].
  
  **Examples:**
  <table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>Peter 22 Varna<br/>George 14 Sofia<br/>END<br/>2</td>
			<td>No matches</td>
		</tr>
		<tr>
			<td>Peter 22 Varna<br>George 22 Varna<br/>George 22 Varna<br/>END<br/>2</td>
			<td>2 1 3 </td>
		</tr>
	</tbody>
</table>
  
  # 6. Equality Logic
Create a class Person holding a name and an age. A person with the same name and age should be considered the same. Override any methods needed to enforce this logic. Your class should work with both standards and hashed collections. Create a SortedSet and a HashSet of type Person. You will receive n – the number of input lines. On each of them, you will receive info about the people in the following format:

"<name> <age>"

You should add the people to both sets. In the end, you should print the size of the sorted set and then the size of the HashSet.

**Input**
- On the first line of input, you will receive a number n.
- On each of the next n lines, you will receive information about people in the described format.

**Output**
- The output should consist of exactly two lines.
- On the first one you should print the size of the sorted set.
- On the second - the size of the HashSet.

**Constraints**
- A person's name will be a string that contains only alphanumerical characters with a length between [1…50] symbols.
- A person's age will be a positive integer between [1…100].
- The number of people N will be a positive integer between [0…100].
  
  **Examples:**
  <table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>4<br/>Peter 20<br/>Petter 20<br/>George 15<br/> Peter 21</td>
			<td>4<br/>4</td>
		</tr>
		<tr>
			<td>7<br/>John 17<br/>john 17<br/>Stoqn 25<br/>John 18<br/>John 17<br/>Sam 25<br/>Samm 25</td>
			<td>5<br/>5 </td>
		</tr>
	</tbody>
</table>
  
  # 7. Custom Comparator

Write a custom comparator that sorts all even numbers before all the odd ones in ascending order. Pass it to Array.Sort() function and print the result. Use functions.
  
  **Examples:**
  <table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>1 2 3 4 5 6</td>
			<td>2 4 6 1 3 5</td>
		</tr>
		<tr>
			<td>-3 2</td>
			<td>2 -3</td>
		</tr>
	</tbody>
</table>
