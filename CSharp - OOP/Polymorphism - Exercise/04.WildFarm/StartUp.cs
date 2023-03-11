using WildFarm.IO.Interfaces;
using WildFarm.IO;
using WildFarm.Factories.Interfaces;
using WildFarm.Factories;
using WildFarm.Core.Intefaces;
using WildFarm.Core;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IAnimalFactory animalFactory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();
            IFarm farm = new Farm(reader, writer, animalFactory, foodFactory);
            farm.Lives();
        }
    }
}