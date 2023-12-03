# 01. DDL 
You have been given the E/R Diagram of the CigarShop

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/68181c61-ce88-413a-a066-fda310849230)

Create a database called CigarShop. You need to create 7 tables:
-	**Sizes** – contains information about the cigar's length and ring range;
-	**Tastes** – contains information about the cigar's taste type, taste strength, and image of the taste;
- **Brands** – contains information about the cigar's brand name and brand description;
-	**Cigars** – contains information for every single cigar;
-	**Addresses** – contains information about the clients' address details;
-	**Clients** – contains information about the customers that buy cigars;
-	**ClientsCigars** – mapping table between clients and cigars.

  You have been tasked to create the tables in the database by the following models:

  **Sizes**
  <table >
	<tbody>
    <tr>
			<td><b>Column Name</b></td>
      <td><b>Data Type</b></td>
      <td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
      <td><b>Integer</b> from 0 to 2,147,483,647</td>
      <td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Length</b></td>
			<td><b>Integer</b> from 0 to 2,147,483,647</td>
      <td>Length should be between <b>10</b> cm. and <b>25</b> cm; <b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>RingRange</b></td>
			<td><b>Decimal</b> number with two-digit precision.</td>
			<td><b>RingRange</b> should be between <b>1.5</b> cm. and <b>7.5</b> cm; <b>NULL</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**Tastes**
<table >
	<tbody>
		 <tr>
			<td><b>Column Name</b></td>
      <td><b>Data Type</b></td>
      <td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
      <td><b>Integer</b> from 0 to 2,147,483,647</td>
      <td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>TasteType</b></td>
			<td><b>String</b> up to <b>20</b> symbols</td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>TasteStrength</b></td>
			<td><b>String</b> up to <b>15</b> symbols</td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>ImageURL</b></td>
			<td><b>String</b> up to <b>100</b> symbols, <b>Unicode</b></td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**Brands**
<table >
	<tbody>
    <tr>
			<td><b>Column Name</b></td>
      <td><b>Data Type</b></td>
      <td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
      <td><b>Integer</b> from 0 to 2,147,483,647</td>
      <td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>BrandName</b></td>
			<td><b>String</b> up to <b>30</b> symbols</td>
			<td>Unique, <b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>BrandDescription</b></td>
			<td>String with maximum length</td>
			<td><b>NULL</b> is allowed</td>
		</tr>
	</tbody>
</table>

**Cigars**
<table >
	<tbody>
		 <tr>
			<td><b>Column Name</b></td>
      <td><b>Data Type</b></td>
      <td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
      <td><b>Integer</b> from 0 to 2,147,483,647</td>
      <td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>CigarName</b></td>
			<td><b>String</b> up to <b>80</b> symbols </td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>BrandId</b> </td>
			<td><b>Integer</b> from 0 to 2,147,483,647</td>
			<td>Relationship with table <b>Brands; NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>TastId</b></td>
			<td><b>Integer</b> from 0 to 2,147,483,647</td>
			<td>Relationship with table <b>Tastes; NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>SizeId</b></td>
			<td><b>Integer</b> from 0 to 2,147,483,647</td>
			<td>PK, Relationship with table <b>Sizes; NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>PriceForSingleCigar</b></td>
			<td>A decimal number used for money calculations.</td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>ImageURL</b></td>
			<td><b>String</b> up to <b>100</b> symbols, <b>Unicode</b>.</td>
			<td><b>NULL</b> is not allowed</td>
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
      <td><b>Integer</b> from 0 to 2,147,483,647</td>
      <td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>Town</b></td>
			<td><b>String</b> up to <b>30</b> symbols</td>
			<td><td><b>NULL</b> is not allowed</td></td>
		</tr>
		<tr>
			<td><b>Country</b></td>
			<td><b>String</b> up to <b>30</b> symbols, Unicode</td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>Streat</b></td>
			<td><b>String</b> up to <b>100</b> symbols, Unicode</td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>ZIP</b></td>
			<td><b>String</b> up to <b>20</b> symbols</td>
			<td><b>NULL</b> is not allowed</td>
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
      <td><b>Integer</b> from 0 to 2,147,483,647</td>
      <td>PK, Unique table identification, Identity</td>
		</tr>
		<tr>
			<td><b>FirstName</b></td>
			<td><b>String</b> up to <b>30</b> symbols, Unicode</td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>LastName</b></td>
			<td><b>String</b> up to <b>30</b> symbols, Unicode</td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>Email</b></td>
			<td><td><b>String</b> up to <b>50</b> symbols, Unicode</td></td>
			<td><b>NULL</b> is not allowed</td>
		</tr>
		<tr>
			<td><b>AddressId</b></td>
			<td><b>Integer</b> from 0 to 2,147,483,647</td>
			<td>Relationship with table <b>Addresses; NULL</b> is not allowed</td>
		</tr>
	</tbody>
</table>

**ClientsCigars**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
      <td><b>Data Type</b></td>
      <td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>ClientId</b></td>
			<td><b>Integer</b> from 0 to 2,147,483,647</td>
			<td>PK, Unique table identification, Relationship with table <b>Clients</b>,  Required</td>
		</tr>
		<tr>
			<td><b>CigarId</b></td>
			<td><b>Integer</b> from 0 to 2,147,483,647</td>
			<td>PK, Unique table identification, Relationship with table <b>Cigars</b>, Required</td>
		</tr>
	</tbody>
</table>

# 02. Insert
Let us insert some sample data into the database. Write a query to add the following records into the corresponding tables. All IDs should be auto-generated.

**Cigars**
<table >
	<tbody>
		<tr>
			<td><b>CigarName</b></td>
			<td><b>BrandId</b></td>
			<td><b>TastId</b></td>
			<td><b>SizeId</b></td>
			<td><b>PriceForSingleCigar</b></td>
			<td><b>ImageURL</b></td>
		</tr>
		<tr>
			<td>COHIBA ROBUSTO</td>
			<td>9</td>
			<td>1</td>
			<td>5</td>
			<td>15.50</td>
			<td>cohiba-robusto-stick_18.jpg</td>
		</tr>
		<tr>
			<td>COHIBA SIGLO I</td>
			<td>9</td>
			<td>1</td>
			<td>10</td>
			<td>410.00</td>
			<td>cohiba-siglo-i-stick_12.jpg</td>
		</tr>
		<tr>
			<td>HOYO DE MONTERREY LE HOYO DU MAIRE</td>
			<td>14</td>
			<td>5</td>
			<td>11</td>
			<td>7.50</td>
			<td>hoyo-du-maire-stick_17.jpg</td>
		</tr>
		<tr>
			<td>HOYO DE MONTERREY LE HOYO DE SAN JUAN</td>
			<td>14</td>
			<td>4</td>
			<td>15</td>
			<td>32.00</td>
			<td>hoyo-de-san-juan-stick_20.jpg</td>
		</tr>
		<tr>
			<td>TRINIDAD COLONIALES</td>
			<td>2</td>
			<td>3</td>
			<td>8</td>
			<td>85.21</td>
			<td>trinidad-coloniales-stick_30.jpg</td>
		</tr>
	</tbody>
</table>

**Addresses**
<table >
	<tbody>
		<tr>
			<td><b>Town</b></td>
			<td><b>Country</b></td>
			<td><b>Streat</b></td>
			<td><b>ZIP</b></td>
		</tr>
		<tr>
			<td>Sofia</td>
			<td>Bulgaria</td>
			<td>18 Bul. Vasil levski</td>
			<td>1000</td>
		</tr>
		<tr>
			<td>Athens</td>
			<td>Greece</td>
			<td>4342 McDonald Avenue</td>
			<td>10435</td>
		</tr>
		<tr>
			<td>Zagreb</td>
			<td>Croatia</td>
			<td>4333 Lauren Drive</td>
			<td>10000</td>
		</tr>
	</tbody>
</table>

# 03. Update
We've decided to increase the price of some **cigars by 20%**. Update the table **Cigars** and increase the price of all cigars, </br>
which **TasteType** is **"Spicy"** by **20%**. Also add the text **"New description"** to every brand, which does not has **BrandDescription**.

# 04. Delete
In table **Addresses**, delete every country which name starts with **'C'**, keep in mind that could be foreign key constraint conflicts.

# 05.	Cigars by Price
Select all **cigars** ordered by **price** (ascending) then by cigar name (descending). 

**Required columns**
-	CigarName
-	PriceForSingleCigar
-	ImageURL

**Example**
<table >
	<tbody>
		<tr>
			<td><b>CigarName</b></td>
			<td><b>PriceForSingleCigar</b></td>
			<td><b>ImageURL</b></td>
		</tr>
		<tr>
			<td>H.UPMANN NO. 2</td>
			<td>5.45</td>
			<td>h-upmann-magnum-50_6_4_1_9.png</td>
		</tr>
		<tr>
			<td>EL-REY-DEL-MUNDO DEMI TASSE</td>
			<td>11.45</td>
			<td>EL-REY-DEL-MUNDO-magnum-50_6_4_1_9.jpg</td>
		</tr>
		<tr>
			<td>VEGUEROS TAPADOS</td>
			<td>15.62</td>
			<td>VEGUEROS-open-junior_1_1_2_1_1_1_4_1_1_1_1_1_1_1_1_2_4_1_9.jpg</td>
		</tr>
		<tr>
			<td>BOLIVAR CORONAS JUNIOR</td>
			<td>17.34</td>
			<td>bolivar-coronas-junior.jpg</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>

# 06.	Cigars by Taste
Select all **cigars** with **"Earthy"** or **"Woody"** tastes. Order results by **PriceForSingleCigar** (descending).

**Required columns**
-	Id
-	CigarName
-	PriceForSingleCigar
-	TasteType
-	TasteStrength

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Id</b></td>
			<td><b>CigarName</b></td>
			<td><b>PriceForSingleCigar</b></td>
			<td><b>TasteType</b></td>
			<td><b>TasteStrength</b></td>
		</tr>
		<tr>
			<td>18</td>
			<td>TRINIDAD CASILDA COLECCION HABANOS 2019</td>
			<td>756.82</td>
			<td>Woody</td>
			<td>Medium</td>
		</tr>
		<tr>
			<td>25</td>
			<td>RAMON ALLONES SMALL CLUB CORONAS</td>
			<td>567.34</td>
			<td>Earthy</td>
			<td>Medium to Full</td>
		</tr>
		<tr>
			<td>39</td>
			<td>MONTECRISTO OPEN MASTER TUBOS</td>
			<td>555.45</td>
			<td>Earthy</td>
			<td>Medium to Full</td>
		</tr>
		<tr>
			<td>38</td>
			<td>MONTECRISTO OPEN JUNIOR</td>
			<td>545.45</td>
			<td>Woody</td>
			<td>Medium</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
      <td>...</td>
      <td>...</td>
      <td>...</td>
		</tr>
	</tbody>
</table>

# 07.	Clients without Cigars
Select all clients **without** cigars. Order them by name (ascending).

**Required columns**
-	Id
-	ClientName – customer's first and last name, concatenated with space
-	Email

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Id</b></td>
			<td><b>ClientName</b></td>
			<td><b>Email</b></td>
		</tr>
		<tr>
			<td>8</td>
			<td>Brenda Wallace</td>
			<td>Wallace.khan@gmail.com</td>
		</tr>
		<tr>
			<td>10</td>
			<td>Harry Jones</td>
			<td>5ornob.Jones@gmail.com</td>
		</tr>
    <tr>
			<td>7</td>
			<td>Jason Hamilton</td>
			<td>nob.Jason@gmail.com</td>
		</tr>
	</tbody>
</table>

# 08.	First 5 Cigars
Select the **first 5 cigars** that are at least **12cm** long and contain **"ci"** in the cigar name or price for a single cigar is bigger than **$50**</br>
and ring range is bigger than **2.55**. Order the result by cigar name (**ascending**), then by price for a single cigar (descending).

**Required columns**
-	CigarName
-	PriceForSingleCigar
-	ImageURL

**Example**
<table >
	<tbody>
		<tr>
			<td><b>CigarName</b></td>
			<td><b>PriceForSingleCigar</b></td>
			<td><b>ImageURL</b></td>
		</tr>
		<tr>
			<td>COHIBA 1966 EDICION LIMITADA 2011</td>
			<td>19.45</td>
			<td>cohiba-siglo-i-stick_18.png</td>
		</tr>
		<tr>
			<td>COHIBA BEHIKE 54</td>
			<td>254.09</td>
			<td>cohiba-esplendidos-stick.jpg</td>
		</tr>
		<tr>
			<td>FONSECA NO. 1</td>
			<td>76.34</td>
			<td>FONSECA-50_6_4_1_9.jpg</td>
		</tr>
		<tr>
			<td>HOYO-DE-MONTERREY EPICURE ESPECIAL</td>
			<td>98.89</td>
			<td>HOYO-DE-MONTERREY-siglo-i-stick_18.jpg</td>
		</tr>
		<tr>
			<td>HOYO-DE-MONTERREY EPICURE NO. 2</td>
			<td>78.57</td>
			<td>HOYO-DE-MONTERREY-siglo-i-stick_18.jpg</td>
		</tr>
	</tbody>
</table>
