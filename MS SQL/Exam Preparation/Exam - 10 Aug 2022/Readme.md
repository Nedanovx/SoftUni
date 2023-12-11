# 01. DDL

You have been given the following E/R Diagram.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/969810c5-33e4-4c89-8ce2-b00581a2302b)

You have been tasked to create the tables in the database by the following models:

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
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique</b> table identification, <b>Identity</b></td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><b>String up to 50 symbols</b></td>
			<td><b>Null is not allowed</b></td>
		</tr>
	</tbody>
</table>

**Locations**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique</b> table identification, <b>Identity</b></td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><b>String up to 50 symbols</b></td>
			<td><b>Null is not allowed</b></td>
		</tr>
    <tr>
			<td><b>Municipality</b></td>
			<td><b>String up to 50 symbols</b></td>
			<td><b>Null is allowed</b></td>
		</tr>
    <tr>
			<td><b>Province</b></td>
			<td><b>String up to 50 symbols</b></td>
			<td><b>Null is allowed</b></td>
		</tr>
	</tbody>
</table>

**Sites**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique</b> table identification, <b>Identity</b></td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><b>String up to 100 symbols</b></td>
			<td><b>Null is not allowed</b></td>
		</tr>
    <tr>
			<td><b>LocationId</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>Relationship with table Locations,  Null is not allowed</b></td>
		</tr>
    <tr>
			<td><b>CategoryId</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>Relationship with table Categories, Null is not allowed</b></td>
		</tr>
    <tr>
			<td><b>Establishment</b></td>
			<td><b>String up to 15 symbols</b></td>
			<td><b>Null is allowed</b></td>
		</tr>
	</tbody>
</table>

**Tourists**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique</b> table identification, <b>Identity</b></td>
		</tr>
		<tr>
			<td><b>Name</b></td>
			<td><b>String up to 50 symbols</b></td>
			<td><b>Null is not allowed</b></td>
		</tr>
    <tr>
			<td><b>Age</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>In range between 0 (inclusive) and 120 (inclusive). Null is not allowed</b></td>
		</tr>
    <tr>
			<td><b>PhoneNumber</b></td>
			<td><b>String up to 20 symbols</b></td>
			<td><b>Null is not allowed</b></td>
		</tr>
     <tr>
			<td><b>Nationality</b></td>
			<td><b>String up to 30 symbols</b></td>
			<td><b>Null is not allowed</b></td>
		</tr>
    <tr>
			<td><b>Reward</b></td>
			<td><b>String up to 20 symbols</b></td>
			<td><b>Null is allowed</b></td>
		</tr>
	</tbody>
</table>

**SitesTourists**
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>TouristId</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique table identification, Relationship with table Tourists
Null is not allowed
</b></td>
		</tr>
		<tr>
			<td><b>SiteId</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique table identification, Relationship with table Sites.
Null is not allowed
</b></td>
	</tbody>
</table>

**BonusPrizes**
  <table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>Id</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique</b> table identification, <b>Identity</b></td>
		</tr>
			<td><b>Name</b></td>
			<td><b>String up to 50 symbols</b></td>
			<td><b>Null is not allowed</b></td>
	</tbody>
</table>

**TouristsBonusPrizes
<table >
	<tbody>
		<tr>
			<td><b>Column Name</b></td>
			<td><b>Data Type</b></td>
			<td><b>Constraints</b></td>
		</tr>
		<tr>
			<td><b>TouristId</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique table identification, Relationship with table Tourists
Null is not allowed
</b></td>
		</tr>
		<tr>
			<td><b>BonusPrizeId</b></td>
			<td><b>Integer</b> from <b>0 to 2,147,483,647</b></td>
			<td><b>PK, Unique table identification, Relationship with table BonusPrizes
Null is not allowed
</b></td>
	</tbody>
</table>

# 02.	Insert
Let's insert some sample data into the database. Write a query to add the following records into the corresponding tables. All Ids should be auto-generated.

**Tourists**
<table >
	<tbody>
    <tr>
			<td><b>Name</b></td>
			<td><b>Age</b></td>
			<td><b>PhoneNumber</b></td>
			<td><b>Nationality</b></td>
			<td><Reward</</td>
		</tr>
		<tr>
			<td>Borislava Kazakova</td>
			<td>52</td>
			<td>+359896354244</td>
			<td>Bulgaria</td>
			<td>NULL</td>
		</tr>
		<tr>
			<td>Peter Bosh</td>
			<td>48</td>
			<td>+447911844141</td>
			<td>UK</td>
			<td>NULL</td>
		</tr>
		<tr>
			<td>Martin Smith</td>
			<td>29</td>
			<td>+353863818592</td>
			<td>Ireland</td>
			<td>Bronze badge</td>
		</tr>
		<tr>
			<td>Svilen Dobrev</td>
			<td>49</td>
			<td>+359986584786</td>
			<td>Bulgaria</td>
			<td>Silver badge</td>
		</tr>
		<tr>
			<td>Kremena Popova</td>
      <td>38</td>
			<td>+359893298604</td>
			<td>Bulgaria</td>
			<td>NULL</td>
		</tr>
	</tbody>
</table>

**Sites**
<table >
	<tbody>
		<tr>
			<td><b>Name</b></td>
			<td><b>LocationId</b></td>
			<td><b>CategoryId</b></td>
			<td><b>Establishment</b></td>
		</tr>
		<tr>
			<td>Ustra fortress</td>
			<td>90</td>
			<td>7</td>
			<td>X</td>
		</tr>
		<tr>
			<td>Karlanovo Pyramids</td>
			<td>65</td>
			<td>7</td>
			<td>NULL</td>
		</tr>
		<tr>
			<td>The Tomb of Tsar Sevt</td>
			<td>63</td>
			<td>8</td>
			<td>V BC</td>
		</tr>
		<tr>
			<td>Sinite Kamani Natural Park</td>
			<td>17</td>
			<td>1</td>
			<td>NULL</td>
		</tr>
		<tr>
			<td>St. Petka of Bulgaria – Rupite</td>
			<td>92</td>
			<td> 6</td>
			<td>1994</td>
		</tr>
	</tbody>
</table>

# 03.	Update
For some of the **tourist sites** there are no clear records when they were established, so you need to **update** the column</br>
**'Establishment'** for those records by putting the text **'(not defined)'**.

# 04.	Delete
For this year's raffle it was decided to **remove** the **Sleeping bag** from the **bonus prizes**.

# 05.	Tourists
Extract information about all the **Tourists – name, age, phone number and nationality. Order** the result by **nationality (ascending)**,</br>
then by **age (descending)**, and then by **tourist name (ascending)**.

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Name</b></td>
			<td><b>Name</b></td>
			<td><b>PhoneNumber</b></td>
			<td><b>Nationality</b></td>
		</tr>
		<tr>
			<td>Danny Kane</td>
			<td>39</td>
			<td>+32487454880</td>
			<td>Belgium</td>
		</tr>
		<tr>
			<td>Krasen Krasenov</td>
			<td>62</td>
			<td>+359897653265</td>
			<td>Bulgaria</td>
		</tr>
		<tr>
			<td>Pavel Mateev</td>
			<td>51</td>
			<td>+359879632123</td>
			<td>Bulgaria</td>
		</tr>
		<tr>
			<td>Kameliya Dimitrova</td>
			<td>42</td>
			<td>+359898645326</td>
			<td>Bulgaria</td>
		</tr>
		<tr>
			<td>Dobroslav Mihalev</td>
			<td>+359889632200</td>
			<td>39</td>
			<td>Bulgaria</td>
		</tr>
		<tr>
			<td>Mariya Petrova</td>
			<td>37</td>
			<td>+359887564235</td>
			<td>Bulgaria</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>



