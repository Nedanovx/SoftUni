namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

           

        }
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            if(!Enum.TryParse<AgeRestriction>(command, true, out var ageRestriction))
            {
                return $"Invalid command!";
            }

            var books = context.Books
                .Where(b=>b.AgeRestriction == ageRestriction)
                .Select(b=> new
                {
                    b.Title
                })
                .OrderBy(b=>b.Title).ToList();

            return String.Join(Environment.NewLine, books.Select(b=>b.Title));
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b =>b.EditionType == EditionType.Gold && b.Copies < 5000)
                .ToList();

            return String.Join(Environment.NewLine, books.Select(b=>b.Title));
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price > 40)
                .Select(b=> new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            return String.Join(Environment.NewLine, books.Select(b => $"{b.Title} - ${b.Price:f2}"));
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .Select(b => new
                {
                    b.Title,

                })
                .ToList();

            return String.Join(Environment.NewLine, books.Select(b=>b.Title));
                
        }
    }
}


