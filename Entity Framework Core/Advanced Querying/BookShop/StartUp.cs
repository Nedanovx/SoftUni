namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Immutable;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);



            Console.WriteLine(RemoveBooks(db));
           

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

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var authors = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    b.Title,
                    b.Author.FirstName,
                    b.Author.LastName
                })
                .ToList();

            return String.Join(Environment.NewLine, authors.Select(a => $"{a.Title} ({a.FirstName} {a.LastName})"));
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return books;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors        
                .Select(a => new
                {
                    a.FirstName,
                    a.LastName,
                    Copies = a.Books.Sum(x => x.Copies)
                })
                .OrderByDescending(x => x.Copies)
                .ToList();



            return String.Join(Environment.NewLine, authors.Select(a => $"{a.FirstName} {a.LastName} - {a.Copies}"));
                
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var result = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Total = c.CategoryBooks.Sum(cb => cb.Book.Copies * cb.Book.Price)
                })
                .OrderByDescending(x => x.Total)
                .ThenBy(x => x.Name);

                

            return String.Join(Environment.NewLine, result.Select(x => $"{x.Name} ${x.Total:f2}"));
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var result = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    MostRecentBooks = c.CategoryBooks.OrderByDescending(cb => cb.Book.ReleaseDate)
                    .Take(3)
                    .Select(cb => new
                    {
                        BookTitle = cb.Book.Title,
                        cb.Book.ReleaseDate.Value.Year
                    })
                })
                .OrderBy(c=>c.CategoryName);

            StringBuilder sb = new();

            foreach(var item in result)
            {
                sb.AppendLine($"--{item.CategoryName}");
                
                foreach(var c in item.MostRecentBooks)
                {
                    sb.AppendLine($"{c.BookTitle} ({c.Year})");
                }
            }

            return sb.ToString().Trim();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year < 2010);

            foreach(var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 4200);

            int count = books.Count();

            context.RemoveRange(books);

            context.SaveChanges();

            return count;
        }
    }
}


