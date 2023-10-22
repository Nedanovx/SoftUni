using Handball.Models.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public class Team : ITeam
    {
        private string name;
        private int pointsEarned;
        private List<IPlayer> players;

        public Team(string name)
        {
            Name = name;
            pointsEarned = 0;
            players = new List<IPlayer>();
        }
        public string Name
        { 
            get { return name; }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                }
                name = value;
            }
        }

        public int PointsEarned => pointsEarned;

        public double OverallRating => Players.Count == 0 ? 0 : Math.Round(players.Average(x => x.Rating), 2); 
       

        public IReadOnlyCollection<IPlayer> Players => players.AsReadOnly();

        public void Draw()
        {
            pointsEarned += 1;
            Players.FirstOrDefault(x => x.GetType().Name == nameof(Goalkeeper)).IncreaseRating();
        }

        public void Lose()
        {
            foreach (IPlayer player in players)
            {
                player.DecreaseRating();
            }
        }

        public void SignContract(IPlayer player)
        {
            players.Add(player);
        }

        public void Win()
        {
            pointsEarned += 3;
            foreach(IPlayer player in players)
            {
                player.IncreaseRating();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Team: {Name} Points: {PointsEarned}");
            sb.AppendLine($"--Overall rating: {OverallRating}");
            sb.Append($"--Players: ");
            if(Players.Count == 0)
            {
                sb.Append("none");
            }
            else
            {
                sb.Append(string.Join(", ", Players.Select(x=>x.Name)));
            }
            return sb.ToString().TrimEnd();
        }
    }
}
