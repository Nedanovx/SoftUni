using BorderControl.Models;
using BorderControl.Models.Interfaces;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IIdentifiable> community = new List<IIdentifiable>();
            while(input != "End")
            {
                string[] inputArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(inputArg.Length == 2)
                {
                    Robot robot = new(inputArg[0], inputArg[1]);
                    community.Add(robot);
                }
                else
                {
                    Citizens person = new(inputArg[0], int.Parse(inputArg[1]), inputArg[2]);
                    community.Add(person);
                }
                input = Console.ReadLine();
            }
            int fakeId = int.Parse(Console.ReadLine());
            string fakeIdToString = fakeId.ToString();
            foreach (IIdentifiable individual in community)
            {
                
                if(individual.Id.EndsWith(fakeIdToString))
                {
                    Console.WriteLine(individual.Id);
                }
                
            }
        }
    }
}