namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }
                string[] animalInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            Dog dog = new(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            Frog frog = new(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(frog);
                            break;
                        case "TomCat":
                            Tomcat tomCat = new(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(animalType);
                            Console.WriteLine(tomCat);
                            break;
                        case "Kitten":
                            Kitten kitten = new(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(animalType);
                            Console.WriteLine(kitten);
                            break;
                        case "Cat":
                            Cat cat = new(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(cat);
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}