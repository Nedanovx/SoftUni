using WildFarm.Core.Intefaces;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Farm : IFarm
    {
        private IReader reader;
        private IWriter writer;
        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;
        private readonly ICollection<IAnimal> animals;
        public Farm(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
            this.animals = new List<IAnimal>();
        }

        public void Lives()
        {
            string input = reader.ReadLine();
            while(input != "End")
            {
                IAnimal animal = null;
                try
                {
                    animal = CreateAnimal(input);
                    IFood food = CreateFood();
                    writer.WriteLine(animal.ProduceSound());
                    animal.Eat(food);
                }
                catch(ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                animals.Add(animal);
                input = reader.ReadLine();
            }
            foreach(IAnimal animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }
        private IAnimal CreateAnimal(string input)
        {
            string[] animalInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return animalFactory.CreateAnimal(animalInfo);
        }
        private IFood CreateFood()
        {
            string[] foodInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);
            return foodFactory.CreatFood(type, quantity);
        }
    }
}
