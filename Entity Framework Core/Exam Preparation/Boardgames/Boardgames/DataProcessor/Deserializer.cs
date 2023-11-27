namespace Boardgames.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ImportDto;
    using Invoices.Extensions;
    using Microsoft.EntityFrameworkCore;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";

        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            StringBuilder sb = new();

            var creatorDtos = xmlString.DeserializeFromXml<ImportCreatorDto[]>("Creators");

            HashSet<Creator> creators = new HashSet<Creator>();

            foreach (var creatorDto in creatorDtos)
            {
                if(!IsValid(creatorDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Creator creator = new Creator()
                {
                    FirstName = creatorDto.FirstName,
                    LastName = creatorDto.LastName
                };

                foreach(var boardgame in  creatorDto.Boardgames)
                {
                    if(!IsValid(boardgame))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    creator.Boardgames.Add( new Boardgame()
                    {
                        Name = boardgame.Name,
                        Rating = boardgame.Rating,
                        YearPublished = boardgame.YearPublished,
                        CategoryType = (CategoryType)boardgame.CategoryType,
                        Mechanics = boardgame.Mechanics
                    });
                    
                }
                creators.Add(creator);
                sb.AppendLine(string.Format(SuccessfullyImportedCreator, creator.FirstName, creator.LastName, creator.Boardgames.Count));
            }
            context.Creators.AddRange(creators);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            var sellerDtos = jsonString.DeserializeFromJson<ImportSellerDto[]>();
            HashSet<Seller> sellers = new HashSet<Seller>();
            int[] gamesIds = context.Boardgames
                .AsNoTracking()
                .Select(bg => bg.Id)
                .ToArray();

            foreach(var sellerDto in sellerDtos)
            {
                if(!IsValid(sellerDto))
                {
                    sb.AppendLine(ErrorMessage); 
                    continue;
                }
                Seller seller = new Seller()
                {
                    Name = sellerDto.Name,
                    Address = sellerDto.Address,
                    Country = sellerDto.Country,
                    Website = sellerDto.Website,
                };

                foreach(var gameId in sellerDto.Boardgames.Distinct())
                {
                    if(!IsValid(gameId) || !gamesIds.Contains(gameId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    seller.BoardgamesSellers.Add(new BoardgameSeller
                    {
                        BoardgameId = gameId
                    });
                }
                sellers.Add(seller);
                sb.AppendLine(string.Format(SuccessfullyImportedSeller, seller.Name, seller.BoardgamesSellers.Count()));
            }
            context.Sellers.AddRange(sellers);
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
