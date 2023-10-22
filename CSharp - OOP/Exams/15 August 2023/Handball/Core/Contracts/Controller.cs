using Handball.Models;
using Handball.Models.Contracts;
using Handball.Repositories;
using Handball.Repositories.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Core.Contracts
{
    public class Controller : IController
    {
        private IRepository<IPlayer> players;
        private IRepository<ITeam> teams;

        public Controller()
        {
            players = new PlayerRepository();
            teams = new TeamRepository();
        }

        public string LeagueStandings()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***League Standings***");
            foreach(var team in teams.Models.OrderByDescending(x=>x.PointsEarned)
                .ThenByDescending(x=>x.OverallRating).ThenBy(x=>x.Name))
            {
                sb.AppendLine(team.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string NewContract(string playerName, string teamName)
        {
            if(!players.ExistsModel(playerName))
            {
                return String.Format(OutputMessages.PlayerNotExisting, playerName, nameof(PlayerRepository));
            }

            if(!teams.ExistsModel(teamName))
            {
                return String.Format(OutputMessages.TeamNotExisting, teamName, nameof(TeamRepository));
            }
            IPlayer player = players.GetModel(playerName);

            if(player.Team != null)
            {
                return String.Format(OutputMessages.PlayerAlreadySignedContract, playerName, player.Team);
            }

            player.JoinTeam(teamName);
            ITeam team = teams.GetModel(teamName);
            team.SignContract(player);
            return String.Format(OutputMessages.SignContract, playerName, teamName);

        }

        public string NewGame(string firstTeamName, string secondTeamName)
        {
            ITeam firstTeam = teams.GetModel(firstTeamName);
            ITeam secondTeam = teams.GetModel(secondTeamName);

            if(firstTeam.OverallRating == secondTeam.OverallRating)
            {
                firstTeam.Draw();
                secondTeam.Draw();
                return String.Format(OutputMessages.GameIsDraw, firstTeamName, secondTeamName);
            }
            else
            {
                ITeam winner;
                ITeam losser;
                if(firstTeam.OverallRating > secondTeam.OverallRating)
                {
                    winner = firstTeam;
                    losser = secondTeam;
                }
                else
                {
                    winner = secondTeam;
                    losser = firstTeam;
                }
                winner.Win();
                losser.Lose();
                return String.Format(OutputMessages.GameHasWinner, winner.Name, losser.Name);
            }
        }

        public string NewPlayer(string typeName, string name)
        {
            if(typeName != nameof(Goalkeeper) && typeName != nameof(CenterBack) && typeName != nameof(ForwardWing))
            {
                return String.Format(OutputMessages.InvalidTypeOfPosition, typeName);
            }
            if(players.ExistsModel(name))
            {
                var playerPosition = players.GetModel(name).GetType().Name;
                return String.Format(OutputMessages.PlayerIsAlreadyAdded, name, nameof(PlayerRepository), playerPosition);
            }
            IPlayer player;
            if (nameof(Goalkeeper) == typeName)
            {
                player = new Goalkeeper(name);
            }
            else if (nameof(CenterBack) == typeName)
            {
                player = new CenterBack(name);
            }
            else
            {
                player = new ForwardWing(name);
            }
            players.AddModel(player);

            return String.Format(OutputMessages.PlayerAddedSuccessfully, name);

        }

        public string NewTeam(string name)
        {
            if(teams.ExistsModel(name))
            {
                return String.Format(OutputMessages.TeamAlreadyExists, name, nameof(TeamRepository));
            }
            ITeam team = new Team(name);
            teams.AddModel(team);
            return String.Format(OutputMessages.TeamSuccessfullyAdded, name, nameof(TeamRepository));
        }

        public string PlayerStatistics(string teamName)
        {
            ITeam team = teams.GetModel(teamName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"***{teamName}***");
            foreach (var player in team.Players.OrderByDescending(x=>x.Rating).ThenBy(x=>x.Name))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
