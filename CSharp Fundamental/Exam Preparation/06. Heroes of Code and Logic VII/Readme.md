# Problem - Heroes of Code and Logic VII

You got your hands on the most recent update on the best MMORPG of all time – Heroes of Code and Logic. You want to play it all day long!</br>
So cancel all other arrangements and create your party!</br>
On the first line of the standard input, you will receive an integer n – the number of heroes that you can choose for your party.</br>
On the next n lines, the heroes themselves will follow with their **hit points** and **mana points** separated by a single space in the following format:</br> 
**"{hero name} {HP} {MP}"**

-	**HP** stands for hit points and **MP** for mana points
-	a hero can have a maximum of **100 HP** and **200 MP**
-	
After you have successfully picked your heroes, you can start playing the game.
You will be receiving different commands, each on a new line, separated by " – ", until the **"End"** command is given. 

There are several actions that the heroes can perform:

**"CastSpell – {hero name} – {MP needed} – {spell name}"**
-	If the hero has the required MP, he casts the spell, thus reducing his MP. Print this message: 
    -	**"{hero name} has successfully cast {spell name} and now has {mana points left} MP!"**
-	If the hero is unable to cast the spell print:
    -	**"{hero name} does not have enough MP to cast {spell name}!"**</br>
      **"TakeDamage – {hero name} – {damage} – {attacker}"**
-	Reduce the hero HP by the given damage amount. If the hero is still alive (his HP is greater than 0) print:
    -	**"{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"**
-	If the hero has died, remove him from your party and print:</br>
    -	**"{hero name} has been killed by {attacker}!"**</br>
      **"Recharge – {hero name} – {amount}"**
-	The hero increases his MP. If it brings the MP of the hero above the **maximum value (200)**, MP is increased to 200. (the MP can't go over the maximum value).
-	 Print the following message:</br>
    -	**"{hero name} recharged for {amount recovered} MP!"**</br>
      **"Heal – {hero name} – {amount}"**
-	The hero increases his HP. If a command is given that would bring the HP of the hero above the maximum value (100), HP is increased to 100 (the HP can't go over the maximum value).
-	 Print the following message:
    -	**"{hero name} healed for {amount recovered} HP!"**

**Input**
-	On the first line of the standard input, you will receive an integer n.
-	On the following n lines, the heroes themselves will follow with their **hit points** and **mana points** separated by a space in the following format.
-	You will be receiving different **commands**, each on a new line, separated by " – ", until the **"End"** command is given.

**Output**
-	Print all members of your party who are still alive, in the following format (their HP/MP need to be indented 2 spaces):</br>
**"{hero name}**</br>
 **HP: {current HP}**</br>
 **MP: {current MP}"**</br>

**Constraints**
-	The starting HP/MP of the heroes will be valid, 32-bit integers will never be negative or exceed the respective limits.
-	The HP/MP amounts in the commands will never be negative.
-	The hero names in the commands will always be valid members of your party. No need to check that explicitly.

**Examples**
<table >
	<tbody>
		<tr>
			<td><b>Input<b></td>
			<td><b>Output</b></td>
		</tr>
		<tr>
			<td>2</br>
Solmyr 85 120</br>
Kyrre 99 50</br>
${\color{green}Heal - Solmyr - 10}$</br>
${\color{purple}Recharge - Solmyr - 50}$</br>
${\color{red}TakeDamage - Kyrre - 66 - Orc}$</br>
${\color{blue}CastSpell - Kyrre - 15 - ViewEarth}$</br>
${\color{yellow}End}$
</td>
			<td>${\color{green}Solmyr healed for 10 HP!}$</br>
      ${\color{purple}Solmyr recharged for 50 MP!}$</br>
      ${\color{red}Kyrre was hit for 66 HP by Orc and now has 33 HP left!}$</br>
      ${\color{blue}Kyrre has successfully cast ViewEarth and now has 35 MP!}$</br>
      ${\color{yellow}Solmyr}$</br>
      &nbsp;&nbsp; ${\color{yellow}HP: 95}$</br>
      &nbsp;&nbsp; ${\color{yellow}MP: 170}$</br>
      ${\color{yellow}Kyrre}$</br>
      &nbsp;&nbsp; ${\color{yellow}HP: 33}$</br>
      &nbsp;&nbsp; ${\color{yellow}MP: 35}$
      </td>
		</tr>
	</tbody>
</table>
