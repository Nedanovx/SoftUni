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

# 06. Products by Category
Select all **products** with **"ADR"** or **"Others"** categories. Order results by **Price** (descending).

**Required columns:**
- Id
- Name
- Price
- CategoryName

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Id</b></td>
			<td><b>Name</b></td>
			<td><b>Price</b></td>
			<td><b>v</b></td>
		</tr>
		<tr>
			<td>69</td>
			<td>Steel armor for trailer</td>
			<td>1350.00</td>
			<td>Others</td>
		</tr>
		<tr>
			<td>15</td>
			<td>Air bag for trailer</td>
			<td>130.06</td>
			<td>Others</td>
		</tr>
		<tr>
			<td>17</td>
			<td>Break pads for trailer</td>
			<td>89.60</td>
			<td>Others</td>
		</tr>
		<tr>
			<td>10</td>
			<td>Groupage board-Load limiter</td>
			<td>79.33</td>
			<td>ADR</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>

# 07. Clients without Products
Select all clients **without** products. Order them by name (ascending).

**Required columns:**
- Id
- Client
- Address

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Id</b></td>
			<td><b>Client</b></td>
			<td><b>Address</b></td>
		</tr>
		<tr>
			<td>8</td>
			<td>JUAN Y ENRIQUE SANCHEZ GA</td>
			<td>Carretera de Madrid 240, Albacete, 20080, Spain</td>
		</tr>
		<tr>
			<td>12</td>
			<td>ROMO BELLIDO SOCIEDAD LIM</td>
			<td>Carretera 330, Carinena, 50400, Spain</td>
		</tr>
	</tbody>
</table>

# 08. First 7 Invoices
Select the first **7** invoices that were **issued before 2023-01-01** and have an **EUR** currency or the **amount** of an invoice is **greater** than **500.00** and the **VAT** number **of** the corresponding client starts with **"DE"**. Order the result by **invoice number (ascending)**, then by **amount (descending)**.

**Required columns:**
- Number
- Amount
- Client

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Number</b></td>
			<td><b>v</b></td>
			<td><b>Client</b></td>
		</tr>
		<tr>
			<td>219066487</td>
			<td>891.76</td>
			<td>219066487</td>
		</tr>
		<tr>
			<td>320983369</td>
			<td>704.48</td>
			<td>BTS GMBH & CO KG</td>
		</tr>
		<tr>
			<td>365934879</td>
			<td>615.15</td>
			<td>FAHRZEUGBEDARF KOTZ & CO</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>

# 09. Clients with VAT
Select all of the clients that have a name, **not** ending in **"KG"**, and display their most expensive product and their VAT number. Order by product price (descending).

**Required columns:**
- Client
- Price
- VAT Number

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Client</b></td>
			<td><b>Price</b></td>
			<td><b>VAT Number</b></td>
		</tr>
		<tr>
			<td>TALLERES MAVIMA SL</td>
			<td>1350.00</td>
			<td>ESB26163097</td>
		</tr>
		<tr>
			<td>DPS EUROPE AB</td>
			<td>375.00</td>
			<td>SE556488676901</td>
		</tr>
		<tr>
			<td>B & H TRANSPORT LOGISTIK</td>
			<td>309.76</td>
			<td>ATU53998900</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>

# 10. Clients by Price
Select all clients, which have bought products. Select their name and average price (rounded down to the nearest integer). Show only the results for clients, whose products are distributed by vendors with **"FR"** in their VAT number. Order the results by **average price (ascending)**, then by client name (descending).

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Client</b></td>
			<td><b>Average Price</b></td>
		</tr>
		<tr>
			<td>FRANZ SCHMID GMBH & CO K</td>
			<td>9</td>
		</tr>
		<tr>
			<td>FRANZ SCHMID GMBH & CO K</td>
			<td>14</td>
		</tr>
		<tr>
			<td>JOSEF PAUL GMBH & COKG</td>
			<td>15</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>

# 11. Product with Clients
Create a user-defined function, named **udf_ProductWithClients(@name)** that receives a product's name.
The function should return the total number of clients that the product has been sold to.

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Query</b></td>
		</tr>
		<tr>
			<td>SELECT dbo.udf_ProductWithClients('DAF FILTER HU12103X')</td>
		</tr>
		<tr>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>3</td>
		</tr>
	</tbody>
</table>

# 12. Search for Vendors from a Specific Country
Create a stored procedure, named **usp_SearchByCountry(@country)** that receives a country name. The procedure must print full information about all vendors that have an address in the given country: **Name, NumberVAT, Street Name and Number (concatenated), PostCode and City (concatenated). Order them by Name (ascending) and City (ascending)**.

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Query</b></td>
		</tr>
		<tr>
			<td>EXEC usp_SearchByCountry 'France'</td>
		</tr>
	</tbody>
</table>

<table >
	<tbody>
		<tr>
			<td><b>Vendor</b></td>
			<td><b>VAT</b></td>
			<td><b>Street Info</b></td>
			<td><b>City Info</b></td>
		</tr>
		<tr>
			<td>LE RELAIS DES PRIMEURS</td>
			<td>FR64431553163</td>
			<td>Rue de la Gare 17</td>
			<td>Taule 29670</td>
		</tr>
		<tr>
			<td>SARL HEBERGECO</td>
			<td>FR75532664075</td>
			<td>Route de Orleans 37</td>
			<td>Evreux 27000</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>
