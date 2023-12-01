namespace Footballers.DataProcessor
{
    using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
    using Footballers.Data;
    using Footballers.Data.Models;
    using Footballers.Data.Models.Enums;
    using Footballers.DataProcessor.ImportDto;
    using Invoices.Extensions;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCoach
            = "Successfully imported coach - {0} with {1} footballers.";

        private const string SuccessfullyImportedTeam
            = "Successfully imported team - {0} with {1} footballers.";

        public static string ImportCoaches(FootballersContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            var coachesDtos = xmlString.DeserializeFromXml<ImportCoachDto[]>("Coaches");
            var coaches = new HashSet<Coach>();

            foreach(var coachDto in coachesDtos)
            {
                if(!IsValid(coachDto) || string.IsNullOrEmpty(coachDto.Nationality))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var coach = new Coach()
                {
                    Name = coachDto.Name,
                    Nationality = coachDto.Nationality,
                };
      
                foreach (var footballer in coachDto.Footballers)
                {
                    DateTime contractStartDate;
                    DateTime contractEndDate;

                    if (!IsValid(footballer))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if(!DateTime.TryParseExact(footballer.ContractStartDate, "dd/MM/yyyy", 
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out contractStartDate))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (!DateTime.TryParseExact(footballer.ContractEndDate, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out contractEndDate))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if(contractStartDate > contractEndDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    coach.Footballers.Add(new Footballer
                    {
                        Name = footballer.Name,
                        ContractStartDate = contractStartDate,
                        ContractEndDate = contractEndDate,
                        BestSkillType = (BestSkillType)footballer.BestSkillType,
                        PositionType = (PositionType)footballer.PositionType
                    });               
                }
                coaches.Add(coach);
                sb.AppendLine(string.Format(SuccessfullyImportedCoach, coach.Name, coach.Footballers.Count));
            }
            context.Coaches.AddRange(coaches);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportTeams(FootballersContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            var teams = new HashSet<Team>();

            var teamDtos = jsonString.DeserializeFromJson<ImportTeamDto[]>();

            int[] footballerIds = context.Footballers
                .Select(f => f.Id)
                .ToArray();

            foreach(var teamDto in  teamDtos)
            {
                if(!IsValid(teamDto))
                {
                    sb.AppendLine(ErrorMessage); 
                    continue;
                }
                if(string.IsNullOrEmpty(teamDto.Nationality))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if(teamDto.Trophies < 1)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var team = new Team()
                {
                    Name = teamDto.Name,
                    Nationality = teamDto.Nationality,
                    Trophies = teamDto.Trophies
                };

                foreach(var footballerId in teamDto.Footballers.Distinct())
                {
                    if(!footballerIds.Contains(footballerId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    team.TeamsFootballers.Add(new TeamFootballer()
                    {
                        FootballerId = footballerId
                    });
                }
                teams.Add(team);
                sb.AppendLine(string.Format(SuccessfullyImportedTeam, team.Name, team.TeamsFootballers.Count));
            }
            context.Teams.AddRange(teams);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
