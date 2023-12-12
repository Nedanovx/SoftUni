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

# 06. Sites with Their Location and Category
Select all sites and find their **location** and category. Select the name of the **tourist site**, name of **the location,  establishment year/ century** and name of the **category. Order** the result by name of the **category (descending)**, then by name of the **location (ascending)** and then by name of the **site** itself **(ascending)**.

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Site</b></td>
			<td><b>Location</b></td>
			<td><b>Establishment</b></td>
			<td><b>Category</b></td>
		</tr>
		<tr>
			<td>Clock Tower – Botevgrad</td>
			<td>Botevgrad</td>
			<td>1866</td>
			<td>Spare time in the city</td>
		</tr>
		<tr>
			<td>Clock Tower of Etropole</td>
			<td>Etropole</td>
			<td>1710</td>
			<td>Spare time in the city</td>
		</tr>
		<tr>
			<td>House of Humour and Satire Museum – Gabrovo</td>
			<td>Gabrovo</td>
			<td>1972</td>
			<td>Spare time in the city</td>
		</tr>
		<tr>
			<td>Museum of Education – Gabrovo</td>
			<td>Gabrovo</td>
			<td>1974</td>
			<td>Spare time in the city</td>
		</tr>
		<tr>
			<td>Antique Theater – Plovdiv</td>
			<td>Plovdiv</td>
			<td>II</td>
			<td>Spare time in the city</td>
		</tr>
		<tr>
			<td>Salt Museum – Pomorie</td>
			<td>Pomorie</td>
			<td>2002</td>
			<td>Spare time in the city</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>

# 07. Count of Sites in Sofia Province
Extract **all locations** which are in **Sofia province**. Find the **count of sites** in every **location**. Select the name of the **province**, name of the **municipality**, name of the **location** and **count** of the **tourist sites** in it. **Order** the result by **count of tourist sites (descending)** and then by **name of the location (ascending)**.

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Province</b></td>
			<td><b>Municipality</b></td>
			<td><b>Location</b></td>
			<td><b>CountOfSites</b></td>
		</tr>
		<tr>
			<td>Sofia</td>
			<td>Sofia</td>
			<td>Sofia</td>
			<td>11</td>
		</tr>
		<tr>
			<td>Sofia</td>
			<td>Etropole</td>
			<td>Etropole</td>
			<td>3</td>
		</tr>
		<tr>
			<td>Sofia</td>
			<td>Botevgrad</td>
			<td>Botevgrad</td>
			<td>1</td>
		</tr>
		<tr>
			<td>Sofia</td>
			<td>Koprivshtitsa</td>
			<td>Koprivshtitsa</td>
			<td>1</td>
		</tr>
		<tr>
			<td>Sofia</td>
			<td>Svoge</td>
			<td>Osenovlag village</td>
			<td>1</td>
		</tr>
		<tr>
			<td>Sofia</td>
			<td>Samokov</td>
			<td>Samokov</td>
			<td>1</td>
		</tr>
	</tbody>
</table>

# 08. Tourist Sites established BC
Extract information about the **tourist sites**, which have a **location name** that **does NOT start** with the letters **'B', 'M' or 'D'** and which are **established Before Christ (BC)**. Select the **site name, location name, municipality, province and establishment. Order** the result by name of the site **(ascending)**.

**NOTE: If the establishment century is Before Christ (BC), it will always be in the following format: 'RomanNumeral BC'.**

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Site</b></td>
			<td><b>Location</b></td>
			<td><b>Municipality</b></td>
			<td><b>Province</b></td>
			<td><b>Establishment</b></td>
		</tr>
		<tr>
			<td>Asen's Fortress</td>
			<td>Asenovgrad</td>
			<td>Asenovgrad</td>
			<td>Plovdiv</td>
			<td>V BC</td>
		</tr>
		<tr>
			<td>National archaeological reserve Kabile</td>
			<td>Yambol</td>
			<td>Yambol</td>
			<td>Yambol</td>
			<td>II BC</td>
		</tr>
		<tr>
			<td>Perperikon – Medieval Archaeological Complex</td>
			<td>Rhodope Mountain</td>
			<td>NULL</td>
			<td>NULL</td>
			<td>V BC</td>
		</tr>
		<tr>
			<td>Shumen Fortress Historical-Archaeological Preserve</td>
			<td>Shumen</td>
			<td>Shumen</td>
			<td>Shumen</td>
			<td>I BC</td>
		</tr>
		<tr>
			<td>Starosel – Thracian Temple Complex</td>
			<td>Starosel village</td>
			<td>Hisarya</td>
			<td>Plovdiv</td>
			<td>V BC</td>
		</tr>
		<tr>
			<td>Thracian Tomb of Kazanlak</td>
			<td>Kazanlak</td>
			<td>Karlovo</td>
			<td>Plovdiv</td>
			<td>IV BC</td>
		</tr>
	</tbody>
</table>

# 09. Tourists with their Bonus Prizes
Extract information about the **tourists**, along with their **bonus prizes**. If there is **no data** for the **bonus prize** put '**(no bonus prize)**'. Select tourist's** name, age, phone number, nationality and bonus prize. Order** the result by the **name** of the **tourist (ascending)**.

**NOTE: There will never be a tourist with more than one prize.**

**Example**
<table >
	<tbody>
		<tr>
			<td><b>Name</b></td>
			<td><b>Age</b></td>
			<td><b>PhoneNumber</b></td>
			<td><b>Nationality</b></td>
			<td><b>Reward</b></td>
		</tr>
		<tr>
			<td>Alonzo Conti</td>
			<td>36</td>
			<td>+393336258996</td>
			<tdItaly</td>
			<td>(no bonus prize)</td>
		</tr>
		<tr>
			<td>Brus Brown</td>
			<td>42</td>
			<td>+447459881347</td>
			<td>UK</td>
			<td>(no bonus prize)</td>
		</tr>
		<tr>
			<td>Claudia Reuss</td>
			<td>54</td>
			<td>+4930774615846</td>
			<td>Germany</td>
			<td>Sleeping bag</td>
		</tr>
				<tr>
			<td>Cosimo Ajello</td>
			<td>51</td>
			<td>+393521112654</td>
			<td>Italy</td>
			<td>(no bonus prize)</td>
		</tr>
				<tr>
			<td>Cyrek Gryzbowski</td>
			<td>64</td>
			<td>+48503435735</td>
			<td>Poland</td>
			<td>(no bonus prize)</td>
		</tr>
				<tr>
			<td>Danny Kane</td>
			<td>39</td>
			<td>+32487454880</td>
			<td>Belgium</td>
			<td>Water filter jug</td>
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

# 10. Tourists visiting History and Archaeology sites
Extract all **tourists**, who have visited sites from **category 'History and archaeology'**. Select their **last name, nationality, age and phone number. Order** the result by their **last name (ascending)**.

**NOTE: The name of the tourists will always be in the following format: 'FirstName LastName'**.

**Example**
<table >
	<tbody>
		<tr>
			<td><b>LastName</b></td>
			<td><b>Nationality</b></td>
			<td><b>Age</b></td>
			<td><b>v</b></td>
		</tr>
		<tr>
			<td>Bauer</td>
			<td>Germany</td>
			<td>49</td>
			<td>+496913265224</td>
		</tr>
		<tr>
			<td>Becker</td>
			<td>Germany</td>
			<td>36</td>
			<td>+491711234567</td>
		</tr>
		<tr>
			<td>Bianchi</td>
			<td>Italy</td>
			<td>51</td>
			<td>+393125965845</td>
		</tr>
		<tr>
			<td>Brown</td>
			<td>UK</td>
			<td>42</td>
			<td>+447459881347</td>
		</tr>
		<tr>
			<td>Conti</td>
			<td>Italy</td>
			<td>36</td>
			<td>+393336258996</td>
		</tr>
		<tr>
			<td>Dimitrova</td>
			<td>Bulgaria</td>
			<td>42</td>
			<td>+359898645326</td>
		</tr>
		<tr>
			<td>...</td>
			<td>...</td>
			<td>...</td>
			<td>...</td>
		</tr>
	</tbody>
</table>

# 11. Tourists Count on a Tourist Site
Create a **user-defined function** named **udf_GetTouristsCountOnATouristSite (@Site)** which receives a **tourist site** and returns the count of **tourists**, who have visited it.

**Examples**
<table >
	<tbody>
		<tr>
			<td><b>Query</b></td>
		</tr>
		<tr>
			<td>SELECT dbo.udf_GetTouristsCountOnATouristSite ('Regional History Museum – Vratsa')</td>
		</tr>
		<tr>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>6</td>
		</tr>
	</tbody>
</table>

<table >
	<tbody>
		<tr>
			<td><b>Query</b></td>
		</tr>
		<tr>
			<td>SELECT dbo.udf_GetTouristsCountOnATouristSite ('Samuil’s Fortress')</td>
		</tr>
		<tr>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>8</td>
		</tr>
	</tbody>
</table>

# 12. Annual Reward Lottery
A reward scheme has been developed to encourage collection of as many stamps as possible. Depending on the number of stamps collected, participants may receive bronze, silver or gold badges. 

Create a **stored procedure**, named **usp_AnnualRewardLottery(@TouristName). Update** the **reward** of the given **tourist** according to the **count of the sites** he have **visited**:
- **>= 100** receives **'Gold badge'**
- **>= 50** receives **'Silver badge'**
- **>= 25** receives **'Bronze badge'**

Extract the name of the **tourist** and the **reward** he has.

**Example**

<table >
	<tbody>
		<tr>
			<td><b>Query</b></td>
		</tr>
		<tr>
			<td>EXEC usp_AnnualRewardLottery 'Gerhild Lutgard'</td>
		</tr>
	</tbody>
</table>

**Result**
<table >
	<tbody>
		<tr>
			<td><b>Name</b></td>
			<td><b>Reward</b></td>
		</tr>
		<tr>
			<td>Gerhild Lutgard</td>
			<td>Gold badge</td>
		</tr>
	</tbody>
</table>
