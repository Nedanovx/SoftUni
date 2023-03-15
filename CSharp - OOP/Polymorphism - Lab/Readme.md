# 01. MathOperation
NOTE: You need a public StartUp class with the namespace Operations.

Create a class MathOperations, which should have 3 times method Add(). Method Add() has to be invoked with:
- Add(int, int): int
- Add(double, double, double): double
- Add(decimal, decimal, decimal): decimal

You should be able to use the class like this:

```ruby
public static void Main()

{

MathOperations mo = new MathOperations();

Console.WriteLine(mo.Add(2, 3));

Console.WriteLine(mo.Add(2.2, 3.3, 5.5));

Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

}
```
**Examples:**

Output
---|
5<br/>11<br/>9.9
  
# 02. Animals
NOTE: You need a public StartUp class with the namespace Animals.

Create a class Animal, which holds two fields:
- name: string
- favouriteFood: string

An animal has one virtual method ExplainSelf(): string. You should add two new classes - Cat and Dog. <br/>
Override the ExplainSelf() method by adding concrete animal sound on a new line. (Look at examples below)

You should be able to use the class like this:
```ruby
Animal cat = new Cat("Peter", "Whiskas");

Animal dog = new Dog("George", "Meat");

Console.WriteLine(cat.ExplainSelf());

Console.WriteLine(dog.ExplainSelf());
```

**Examples:**

Output
---|
I am Peter and my fovourite food is Whiskas<br/>MEEOW<br/>I am George and my fovourite food is Meat<br/>DJAAF

# 03. Shapes
NOTE: You need a public StartUp class with the namespace Shapes.

Create a class hierarchy, starting with abstract class Shape:
- Abstract methods:
  - CalculatePerimeter(): double
  - CalculateArea(): double

- Virtual methods:
  - Draw(): string
    - The method should get the name of class type as string, and should return a message in the format: $"Drawing {classType.Name}"

Extend the Shape class with two children:
- Rectangle
- Circle

Each of them needs to have:
- Fields:
  - height and width for Rectangle
  - radius for Circle
- Encapsulation for these fields
- A public constructor
- Concrete methods for calculations (perimeter and area)
- Override methods for drawing
