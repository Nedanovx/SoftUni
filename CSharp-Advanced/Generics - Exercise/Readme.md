# 1. Generic Box of String
Create a generic class Box that can be initialized with any type and store the value. Override the ToString() method and print the type and stored value.

**Input**
- On the first line, you will get n - the number of strings to read from the console.
- On the next n lines, you will get the actual strings.
  - For each of them, create a box and call its ToString() method to print its data on the console.

**Output**
- The output should be in the given format:

"{class full name: value}"

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>2<br/>life in a box<br/>box in a lif </td>
			<td>System.String: life in a box<br/> System.String: box in a life</td>
			<td>3<br/>Peter<br/>Simon<br/>Griffin</td>
			<td>System.String: Peter <br/>System.String: <br/>Simon System.String: Griffin</td>
		</tr>
	</tbody>
</table>

# 2. Generic Box of Integer

Use the description of the previous problem but now, test your generic box with Integers.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>1<br/>1001 </td>
			<td>System.Int32: 1001</td>
			<td>3<br/>7<br/>123<br/>42 </td>
			<td>System.Int32: 7<br/> System.Int32: 123<br/> System.Int32: 42 </td>
		</tr>
	</tbody>
</table>

# 3. Generic Swap Method Strings
Create a generic method that receives a list, containing any type of data and swaps the elements at two given indexes.

**Input**
- On the first line, you will read n number of boxes of type string and add them to the list.
- On the next line, however, you will receive a swap command consisting of two indexes.

**Output**
- Use the method you've created to swap the elements that correspond to the given indexes and print each element in the list.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>3<br/>Peter<br/>George<br/>Swap me with Peter<br/>0 2 </td>
			<td>System.String: Swap me with Peter<br/> System.String: George<br/> System.String: Peter</td>
			<td>2<br/>SoftUni<br/>Hello<br/>0 1</td>
			<td>System.String: Hello<br/> System.String: SoftUni</td>
		</tr>
	</tbody>
</table>

# 4. Generic Swap Method Integers
Use the description of the previous problem, but now, test your list of generic boxes with integers.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>3<br/>7<br/>123<br/>42<br/>0 2 </td>
			<td>System.Int32: 42<br/> System.Int32: 123<br/> System.Int32: 7</td>
			<td>3<br/>1<br/>2<br/>3<br/>0 1</td>
			<td>System.Int32: 2<br/> System.Int32: 1<br/>System.Int32: 3</td>
		</tr>
	</tbody>
</table>

# 5. Generic Count Method Strings
Create a method that receives as an argument a list of any type, that can be compared and an element of the given type. 
The method should return the count of elements that are greater than the value of the given element. 
Modify your Box class to support comparison by the value of the stored data.

**Input**
- On the first line, you will receive n - the number of elements to add to the list.
- On the next n lines, you will receive the actual elements.
- On the last line, you will get the value of the element for comparison.

**Output**
- Print the count of elements that are larger than the value of the given element.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>3<br/>aa<br/>aaa<br/>bb<br/>aa</td>
			<td>2</td>
			<td>1<br/>aaa<br/>aa</td>
			<td>1</td>
		</tr>
	</tbody>
</table>

# 6. Generic Count Method Doubles
Use the description of the previous problem, but now, test your list of generic boxes with doubles.

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>3<br/>7.13<br/>123.22<br/>42.78<br/>7.55</td>
			<td>2</td>
			<td>3<br/>1.1<br/> 2.3<br/> 3.2<br/> 1.5</td>
			<td>2</td>
		</tr>
	</tbody>
</table>

# 7. Tuple 
A Tuple is a class in C#, in which you can store a few objects. First, we are going to focus on the Tuple's type, which contains two objects. 
The first one is "item1" and the second one is "item2". It is kind of like a KeyValuePair, except – it simply has items, which are neither key nor value. 
Your task is to create a class "Tuple", which holds two objects. The first one will be "item1" and the second one – "item2". 
The tricky part here is to make the class hold generics. This means, that when you create a new object of class – "Tuple", 
there should be a way to explicitly specify both items' types separately.

**Input**

The input consists of three lines:
- The first one holds a person's name and an address. They are separated by space(s). Your task is to collect them in the tuple and print them on the console. <br/>
Format of the input: {first name} {last name} {address}

- The second line holds a name of a person and the amount of beer (int) he can drink. Format: {name} {liters of beer}

- The last line holds an integer and a double. Format: {integer} {double}

**Output**
- Print the tuples' items in format: {item1} -> {item2}

**Constraints**
- Use the good practices we have learned. Create the class and make it have getters and setters for its class variables. 
The input will be valid, no need to check it explicitly!

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>Adam Smith California<br/>Mark 2<br/>23 21.23212321</td>
			<td>Adam Smith -> California<br/> Mark -> 2<br/> 23 -> 21.23212321</td>
			<td>William Donovan York<br/>Richard 2999999<br/>10 10</td>
			<td>William Donovan -> York<br/> Richard -> 2999999<br/> 10 -> 10</td>
		</tr>
	</tbody>
</table>

# 8. Threeuple
Create a Class Threeuple. Its name is telling us that it will hold no longer, just a pair of objects. The task is simple, our Threeuple should hold three objects. 
Make it have getters and setters. You can even extend the previous class.

**Input**
The input consists of three lines:
- The first one is holding a name, an address and a town. Format of the input:

{first name} {last name} {address} {town}

- The second line is holding a name, beer liters, and a boolean variable with value - drunk or not. Format:

{name} {liters of beer} {drunk or not}

- The last line will hold a name, a bank balance (double) and a bank name. Format:

{name} {account balance} {bank name}

**Output**
- Print the Threeuples' objects in format:

"{firstElement} -> {secondElement} -> {thirdElement}"

**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input</td>
			<td>Output</td>
			<td>Input</td>
			<td>Output</td>
		</tr>
		<tr>
			<td>Adam Smith Wallstreet New York<br/>Mark 18 drunk<br/>Karren 0.10 USBank</td>
			<td>Adam Smith -> Wallstreet -> New York<br/> Mark -> 18 -> True<br/> Karren -> 0.1 -> USBank</td>
			<td>Anatoly Andreevich Kutuzova Kaliningrad<br/>Marley 9 not<br/>Grant 2 NGB</td>
			<td>Anatoly Andreevich -> Kutuzova -> Kaliningrad<br/> Marley -> 9 -> False<br/> Grant -> 2 -> NGB</td>
		</tr>
	</tbody>
</table>
