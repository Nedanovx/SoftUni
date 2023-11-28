namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.DataProcessor.ExportDto;
    using Invoices.Extensions;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
        {
            var creators = context.Creators
                .Where(c => c.Boardgames.Any())
                .Select(c => new ExportCreatorDto()
                {
                    BoardgamesCount = c.Boardgames.Count(),
                    Name = c.FirstName + " " + c.LastName,
                    Boardgames = c.Boardgames
                    .Select(bg => new ExportBoardgameXmlDto()
                    {
                        Name = bg.Name,
                        YearPublished = bg.YearPublished,
                    })
                    .OrderBy(bg => bg.Name)
                    .ToArray()
                    
                })
                .OrderByDescending(c => c.BoardgamesCount)
                .ThenBy(c => c.Name)
                .ToArray();
            return creators.SerializeToXml<ExportCreatorDto[]>("Creators");
        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var sellers = context.Sellers
                .Where(s => s.BoardgamesSellers.Any(bg => bg.Boardgame.YearPublished >= year && bg.Boardgame.Rating <= rating))
                .Select(s => new ExportSellerDto()
                {
                    Name = s.Name,
                    Website = s.Website,
                    Boardgames = s.BoardgamesSellers
                    .Where(bg => bg.Boardgame.YearPublished >= year && bg.Boardgame .Rating <= rating)
                    .Select(bg => new ExportBoardgameDto()
                    {
                        Name = bg.Boardgame.Name,
                        Rating = bg.Boardgame.Rating,
                        Mechanics = bg.Boardgame.Mechanics,
                        Category = bg.Boardgame.CategoryType.ToString()
                    })
                    .OrderByDescending(bg => bg.Rating)
                    .ThenBy(bg => bg.Name)
                    .ToArray()

                })
                .OrderByDescending(s => s.Boardgames.Count())
                .ThenBy(s => s.Name)
                .Take(5)
                .ToArray();

            return JsonConvert.SerializeObject(sellers, Formatting.Indented);
        }
    }
}