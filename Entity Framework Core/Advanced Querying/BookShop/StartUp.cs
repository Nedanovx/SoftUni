namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Storage;
    using System.Collections.Immutable;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            string input = Console.ReadLine();
            
            Console.WriteLine(GetBookTitlesContaining(db, input));
           

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

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.ToLower())
                .ToArray();

            var books = context.Books
                .Select(b=> new
                {
                    b.Title,
                    b.BookCategories
                })
                .Where(b=>b.BookCategories.Any(bc=> categories.Contains(bc.Category.Name.ToLower())))
                .OrderBy(b=>b.Title)
                .ToList();

            return String.Join(Environment.NewLine, books.Select(b => b.Title));
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {

            var parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
           
                var books = context.Books
                    .Where(b => b.ReleaseDate < parsedDate)
                    .Select(b => new
                    {
                        b.Title,
                        b.EditionType,
                        b.Price,
                        b.ReleaseDate
                    })
                    .OrderByDescending(b => b.ReleaseDate)
                    .ToList();
            

            return String.Join(Environment.NewLine, books.Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}"));
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(a=>a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                })
                .OrderBy(a => a.FullName)
                .ToList();

            return String.Join(Environment.NewLine, authors.Select(a => $"{a.FullName}"));
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => new
                {
                    b.Title
                })
                .OrderBy(b => b.Title)
                .ToList();

            return String.Join(Environment.NewLine, books.Select(b => b.Title));
        }
    }
}


