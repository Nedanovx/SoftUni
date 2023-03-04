# 01. Shapes
NOTE: You need a public StartUp class with the namespace Shapes.

Build a hierarchy of interfaces and classes: 

![Untitled](https://user-images.githubusercontent.com/107359038/222922776-41139327-3e61-4e4c-98f5-d8474748ce1e.jpg)

You should be able to use the class like this:
```ruby
var radius = int.Parse(Console.ReadLine());
IDrawable circle = new Circle(radius);

var width = int.Parse(Console.ReadLine());
var height = int.Parse(Console.ReadLine());
IDrawable rect = new Rectangle(width, height);

circle.Draw();
rect.Draw();
```
**Examples:**

![Untitled1](https://user-images.githubusercontent.com/107359038/222923519-2e129fbf-7e2c-41c8-91c8-f3bfc908baf2.jpg)

# 02. Cars
NOTE: You need a public StartUp class with the namespace Cars.

Build a hierarchy of interfaces and classes:

![Untitled2](https://user-images.githubusercontent.com/107359038/222923572-646290f4-97ca-4ee7-b745-0fd8f37e07f3.jpg)

Your hierarchy must be used with this code:
```ruby
ICar seat = new Seat("Leon", "Grey");
ICar tesla = new Tesla("Model 3", "Red", 2);

Console.WriteLine(seat.ToString());
Console.WriteLine(tesla.ToString());
````

**Examples**
<table >
	<tbody>
		<tr>
			<td>Output </td>
		</tr>
		<tr>
			<td>Grey Seat Leon<br/>Engine start<br/>Breaaak!<br/>Red Tesla Model 3 with 2 Batteries<br/>Engine start<br/>Breaaak! </td>
		</tr>
	</tbody>
</table>

