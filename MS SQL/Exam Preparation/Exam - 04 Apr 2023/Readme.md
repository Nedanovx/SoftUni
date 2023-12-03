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

# 02.	Insert
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

# 03.	Update
We've decided to change the **due date** of the **invoices**, issued in **November 2022**.</br>
Update the due date and change it to **2023-04-01**. 

Then, you have to change the **addresses** of the **clients, which contain "CO" in their names**. 
The **new** value of the **addresses** should be **Industriestr, 79, 2353, Guntramsdorf, Austria**.

# 04.	Delete
In table Clients, delete every **client**, whose VAT number starts with **"IT"**. Keep in mind that there could be foreign key constraint conflicts.

