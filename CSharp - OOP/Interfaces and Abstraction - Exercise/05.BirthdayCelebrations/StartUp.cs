using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IBirthable> community = new List<IBirthable>();
            while (input != "End")
            {
                string[] inputArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArg[0];
                switch (command)
                {
                    case "Pet":
                        IBirthable pet = new Pet(inputArg[1], inputArg[2]);
                        community.Add(pet);
                        break;
                    case "Citizen":
                        IBirthable citizen = new Citizens(inputArg[1], int.Parse(inputArg[2]), inputArg[3], inputArg[4]);
                        community.Add(citizen);
                        break;
                }

                input = Console.ReadLine();
            }
            string year = Console.ReadLine();
            foreach (var individual in community)
            {

                if (individual.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(individual.Birthdate);
                }

            }
        }
    }
}