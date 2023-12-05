# Problem Fancy Barcodes

Your first task is to determine if the given sequence of characters is a valid barcode or not. 

**Each line must not contain anything else but a valid barcode**. A barcode is **valid** when:</br>
-	It is surrounded by a **"@"** followed by one or more **"#"**
-	It is **at least 6 characters long** (without the surrounding **"@"** or **"#"**)
-	**It starts with a capital letter**
-	**It contains only letters** (lower and upper case) and **digits**
-	**It ends** with a **capital letter**

Examples of valid barcodes: @###Che46sE@##, @#FreshFisH@#, @###Brea0D@###, @##Che46sE@##

Examples of invalid barcodes: ##InvaliDiteM##, @InvalidIteM@, @#Invalid_IteM@#

Next, you have to determine the product group of the item from the **barcode**.</br>
The product group is obtained by **concatenating all the digits** found in the barcode.</br>
If there are no digits present in the barcode, the default product group is "00".

**Examples: ** 
@#FreshFisH@# -> product group: 00</br>
@###Brea0D@### -> product group: 0</br>
@##Che4s6E@## -> product group: 46</br>

**Input**
On the first line, you will be given an integer n – the count of barcodes that you will be receiving next. </br>
On the following n lines, you will receive different strings.

**Output**
For each barcode that you process, you need to print a message.</br>
If the barcode is invalid:
-	**"Invalid barcode"**</br>
If the barcode is valid:
-	**"Product group: {product group}"**

**Examples**
<table >
	<tbody>
		<tr>
			<td><b>Inpit</b></td>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>6</br>
@###Val1d1teM@###</br>
@#ValidIteM@#</br>
##InvaliDiteM##</br>
@InvalidIteM@</br>
@#Invalid_IteM@#</br>
@#ValiditeM@#
</td>
			<td>Product group: 11</br>
Product group: 00</br>
Invalid barcode</br>
Invalid barcode</br>
Invalid barcode</br>
Product group: 00
</td>
		</tr>
	</tbody>
</table>
