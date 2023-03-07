using FoodShortage.Models.Interfaces;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age,string group )
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name {get; private set;}
        public int Age {get; private set;}
        public string Group { get; private set;}

        public int Food { get; private set;}

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
