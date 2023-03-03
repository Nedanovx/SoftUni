using FootballTeamGenerator.Models;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new();
            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] inputArg = input.Split(";");
                string command = inputArg[0];
                switch(command)
                {
                    case "Team":
                        AddTeam(inputArg[1], teams);
                        break;
                    case "Add":
                        AddPlayer(inputArg[1], inputArg[2],int.Parse(inputArg[3]), int.Parse(inputArg[4]),
                            int.Parse(inputArg[5]), int.Parse(inputArg[6]), int.Parse(inputArg[7]),teams);
                        break;
                    case "Remove":
                        RemovePlayer(inputArg[1], inputArg[2], teams);
                        break;
                    case "Rating":
                        PrintRating(inputArg[1],teams);
                        break;
                }
                input = Console.ReadLine();
            }
        }
        static void AddTeam(string name, List<Team> teams)
        {
            try
            {
                teams.Add(new Team(name));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        static void AddPlayer(string teamName, string name, int endurance, int sprint, int dribble, int passing, int shooting, List<Team>teams)
        {
            Team team = teams.FirstOrDefault(x => x.Name == teamName);

            if(team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return;
            }
            try
            {
                Player player = new(name, endurance, sprint, dribble, passing, shooting);
                team.AddPlayer(player);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        static void RemovePlayer(string teamName, string playerName, List<Team>teams)
        {
            Team team = teams.FirstOrDefault(x => x.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return;
            }
            try
            {
                team.RemovePlayer(playerName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void PrintRating(string teamName, List<Team> teams)
        {
            Team team = teams.FirstOrDefault(x => x.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return;
            }
            Console.WriteLine($"{teamName} - {team.Rating:f0}");
        }
    }
}