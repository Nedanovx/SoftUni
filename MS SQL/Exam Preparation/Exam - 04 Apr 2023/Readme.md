# 01. DDL
You have been given the E/R Diagram of the Accounting database.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/ab34135c-4a37-40fd-8aae-7fe261c5c183)

Create a database called **Accounting**. You need to create 8 tables:
-	**Products** – contains information about each product;
-	**Categories** – containts information about each product's category;
-	**Vendors** – contains information about the products' vendors;
-	**Clients** – contains information about the clients, which the products have been sold to;
-	**Addresses** – contains information about the clients' and vendors' addresses;
-	**Countries** – contains information about the countries, in which the addresses are located;
-	**Invoices**  – contains information about the invoices, issued to the clients;
-	**ProductsClients** – mapping table between products and clients.

**Countries**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><b>String</b> up to <b>10</b> symbols</td>
			<td><b>Null</b> is not allowed</td>
</tr>
</tbody>
</table>

**Addresses**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>StreetName</b></td>
			<td><b>String</b>up to <b>20</b> symbols, Unicode</td>
			<td><b>Null</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>StreetNumber</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td><b>Null</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>PostCode</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td><b>Null</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>City</b></td>
			<td><b>String</b>up to <b>25</b> symbols</td>
			<td><b>Null</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>CountryId</b></td>
			<td><td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td></td>
			<td>Relationship with table <b>Countries, Null</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**Vendors**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><td><b>String</b>up to <b>25</b> symbols, Unicode</td></td>
			<td><td><b>Null</b> is not allowed</td></td>
		</tr>
		<tr>
			<td><b>NumberVAT</b></td>
			<td><td><b>String</b>up to <b>15</b> symbols, Unicode</td></td>
			<td><td><b>Null</b> is not allowed</td></td>
		</tr>
		<tr>
			<td><b>AddressId</b></td>
			<td><td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td></td>
			<td>Relationship with table <b>Addresses, Null</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**Clients**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><td><b>String</b>up to <b>25</b> symbols, Unicode</td></td>
			<td><td><b>Null</b> is not allowed</td></td>
		</tr>
		<tr>
			<td><b>NumberVAT</b></td>
			<td><td><b>String</b>up to <b>15</b> symbols, Unicode</td></td>
			<td><td><b>Null</b> is not allowed</td></td>
		</tr>
		<tr>
			<td><b>AddressId</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>Relationship with table <b>Addresses, Null</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**Categories**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><td><b>String</b>up to <b>35</b> symbols, Unicode</td></td>
			<td><td><b>Null</b> is not allowed</td></td>
		</tr>
	</tbody>
</table>

**Products**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><td><b>String</b>up to <b>35</b> symbols, Unicode</td></td>
			<td><td><b>Null</b> is not allowed</td></td>
		</tr>
		<tr>
			<td><b>Price</b></td>
			<td><b>Decimal</b>, up to <b>18 digits</b>, 2 of which after the <b>decimal point</b></td>
			<td> </td>
		</tr>
		<tr>
			<td><b>CategoryId</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>Relationship with table <b>Categories, Null</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>VendorId</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>Relationship with table <b>Vendors, Null</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**Invoices**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Number</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>Unique, <b>Null</b> is not allowed.</td>
		</tr>
		<tr>
			<td><b>IssueDate</b></td>
			<td><b>ClientId</b></td>
			<td><b>Null</b> is not allowed.</td>
		</tr>
		<tr>
			<td><b>DueDate</b></td>
			<td><b>ClientId</b></td>
			<td><b>Null</b> is not allowed.</td>
		</tr>
		<tr>
			<td><b>Amount</b></td>
			<td><b>Decimal</b>, up to <b>18 digits, 2</b> symbols <b>decimal point</b></td>
			<td><b>Null</b> is not allowed.</td>
		</tr>
		<tr>
			<td><b>Currency</b></td>
			<td><b>String</b> up to <b>5</b> symbols</td>
			<td><b>Null</b> is not allowed.</td>
		</tr>
		<tr>
			<td><b>ClientId</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>Relationship with table <b>Clients, Null</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**ProductsClients**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>ProductId</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Relationship with table <b>Products, Null</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>ClientId</b></td>
			<td><b>Integer</b> from <b>0</b> to <b>2,147,483,647</b></td>
			<td>PK, Unique table identification, Relationship with table <b>Clients, Null</b> is not allowed</td>
		</tr>
	</tbody>
</table>

# 02. Insert
Let's insert some sample data into the database. Write a query to add the following records into the corresponding tables. All IDs should be auto-generated.

**Products**
<table >
	<tbody>
		<tr>
			<td><b>Name</b></td>
			<td><b>Price</b></td>
			<td><b>CategoryId</b></td>
			<td><b>VendorId</b></td>
		</tr>
		<tr>
			<td>SCANIA Oil Filter XD01</td>
			<td>78.69</td>
			<td>1</td>
			<td>1</td>
		</tr>
		<tr>
			<td>MAN Air Filter XD01</td>
			<td>97.38</td>
			<td>1</td>
			<td>5</td>
		</tr>
		<tr>
			<td>DAF Light Bulb 05FG87</td>
			<td>55.00</td>
			<td>2</td>
			<td>13</td>
		</tr>
		<tr>
			<td>ADR Shoes 47-47.5</td>
			<td>49.85</td>
			<td>3</td>
			<td>5</td>
		</tr>
		<tr>
			<td>Anti-slip pads S</td>
			<td>5.87</td>
			<td>5</td>
			<td>7</td>
		</tr>
	</tbody>
</table>

**Invoices**
<table >
	<tbody>
		<tr>
			<td><b>Number</b></td>
			<td><b>IssueDate</b></td>
			<td><b>DueDate</b></td>
			<td><b>Amount</b></td>
			<td><b>Currency</b></td>
			<td><b>ClientId</b></td>
		</tr>
		<tr>
			<td>1219992181</td>
			<td>2023-03-01</td>
			<td>2023-04-30</td>
			<td>180.96</td>
			<td>BGN</td>
			<td>3</td>
		</tr>
		<tr>
			<td>1729252340</td>
			<td>2022-11-06</td>
			<td>2023-01-04</td>
			<td>158.18</td>
			<td>EUR</td>
			<td>13</td>
		</tr>
		<tr>
			<td>1950101013</td>
			<td>2023-02-17</td>
			<td>2023-04-18</td>
			<td>615.15</td>
			<td>USD</td>
			<td>19</td>
		</tr>
	</tbody>
</table>

# 03. Update
We've decided to change the **due date** of the **invoices**, issued in **November 2022**.</br>
Update the due date and change it to **2023-04-01**. 

Then, you have to change the **addresses** of the **clients, which contain "CO" in their names**. 
The **new** value of the **addresses** should be **Industriestr, 79, 2353, Guntramsdorf, Austria**.

# 04. Delete
In table Clients, delete every **client**, whose VAT number starts with **"IT"**. Keep in mind that there could be foreign key constraint conflicts.

# 05. Invoices by Amount and Date
Select all **invoices**, ordered by **amount** (descending), then by due date (ascending). 

**Required columns**:
- Number
- Currency

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Number</b></td>
			<td><b>Currency</b></td>
		</tr>
		<tr>
			<td>213573806</td>
			<td>BGN</td>
		</tr>
		<tr>
			<td>219066487</td>
			<td>EUR</td>
		</tr>
		<tr>
			<td>320983369</td>
			<td>USD</td>
		</tr>
		<tr>
			<td>349121203</td>
			<td>349121203</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>
