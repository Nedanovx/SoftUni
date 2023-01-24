# 1. Sort Even Numbers
Create a program that reads one line of integers separated by ", ". Then prints the even numbers of that sequence sorted in increasing order.<br/>
**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>4, 2, 1, 3, 5, 7, 1, 4, 2, 12 </td>
			<td>2, 2, 4, 4, 12 </td>
			<td>1, 3, 5 </td>
			<td> </td>
		</tr>
	</tbody>
</table>

# 2. Sum Numbers
Create a program that reads a line of integers separated by ", ". Print on two lines the count of numbers and their sum.<br/>
**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>4, 2, 1, 3, 5, 7, 1, 4, 2, 12 </td>
			<td>10<br/>41 </td>
			<td>2, 4, 6 </td>
			<td>3<br/>12 </td>
		</tr>
	</tbody>
</table>

# 3. Count Uppercase Words
Create a program that reads a line of text from the console. Print all the words that start with an uppercase letter in the same order you've 
received them in the text.<br/>
**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>The following example shows how to use Function </td>
			<td>The<br/>Function </td>
			<td>Write a program that reads one line of text from console. Print count of words that start with Uppercase, after that print all those words in<br/>
the same order like you find them in text.</td>
			<td>Write<br/>Print<br/>Uppercase </td>
		</tr>
	</tbody>
</table>

# 4. Add VAT
Create a program that reads one line of double prices separated by ", ". Print the prices with added VAT for all of them. <br/>
Format them to 2 signs after the decimal point. The order of the prices must be the same. VAT is equal to 20% of the price.
**Examples:**
<table >
	<tbody>
		<tr>
			<td>Input </td>
			<td>Output </td>
			<td>Input </td>
			<td>Output </td>
		</tr>
		<tr>
			<td>1.38, 2.56, 4.4 </td>
			<td>1.66<br/>3.07<br/>5.28 </td>
			<td>1, 3, 5, 7</td>
			<td>1.20<br/> 3.60<br/> 6.00<br/> 8.40 </td>
		</tr>
	</tbody>
</table>

# 5. Filter by Age
Write a program that receives an integer N on the first line. On the next N lines, read pairs of "[name], [age]". Then read three lines:
- Condition - "younger" (<) or "older" (>=)
- Age threshold - integer
- Format - "name", "age" or "name age"

Depending on the condition, print the correct pairs in the correct format. Don't use the built-in functionality from .NET. Create your own methods.

Implement the following steps:
```ruby
List<Person> people = ReadPeople();
Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
Action<Person> printer = CreatePrinter(format); 
PrintFilteredPeople(people, filter, printer);
```
The methods CreateFilter(condition, ageThreshold) and CreatePrinter(format) should return lambda functions as output.
