using WildFarm.Factories.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animalsInfo)
        {
            string type = animalsInfo[0];
            string name = animalsInfo[1];
            double weight = double.Parse(animalsInfo[2]);
            switch (type)
            {
                case "Owl":
                    return new Owl(name, weight, double.Parse(animalsInfo[3]));
                case "Hen":
                    return new Hen(name, weight, double.Parse(animalsInfo[3]));
                case "Mouse":
                    return new Mouse(name, weight, animalsInfo[3]);
                case "Dog":
                    return new Mouse(name, weight, animalsInfo[3]);
                case "Cat":
                    return new Cat(name, weight, animalsInfo[3], animalsInfo[4]);
                case "Tiger":
                    return new Tiger(name, weight, animalsInfo[3], animalsInfo[4]);
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
