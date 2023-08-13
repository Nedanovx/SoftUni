namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    using System.Text;

    public class Tests
    {

        [Test]
        public void ConstructorShouldCreateUniversityLibrary()
        {
            UniversityLibrary library = new UniversityLibrary();
            Assert.IsNotNull(library.Catalogue);
        }
        [Test]
        public void AddTextBookToLibraryShouldWorkCorrectly()
        {
            UniversityLibrary library = new UniversityLibrary();
            TextBook text = new TextBook("roman", "S.King", "horror");
            var action = library.AddTextBookToLibrary(text);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Book: {text.Title} - {text.InventoryNumber}");
            sb.AppendLine($"Category: {text.Category}");
            sb.AppendLine($"Author: {text.Author}");
            var result = sb.ToString().TrimEnd();
            Assert.AreEqual(result, action);
            Assert.AreEqual(1, library.Catalogue.Count);
        }
        [Test]
        public void LoanTextBookShouldCanLoanBook()
        {
            UniversityLibrary library = new UniversityLibrary();
            TextBook text = new TextBook("roman", "S.King", "horror");
            library.AddTextBookToLibrary(text);
            TextBook text1 = new TextBook("SomeText", "Ivan", "humor");
            library.AddTextBookToLibrary(text1);
            var result = library.LoanTextBook(2, "Koko");
            Assert.AreEqual($"{text1.Title} loaned to {text1.Holder}.", result);
        }
        [Test]
        public void LoanTextBookShouldCanNotLoanBook()
        {
            UniversityLibrary library = new UniversityLibrary();
            TextBook text = new TextBook("roman", "S.King", "horror");
            library.AddTextBookToLibrary(text);
            TextBook text1 = new TextBook("SomeText", "Ivan", "humor");
            library.AddTextBookToLibrary(text1);
            library.LoanTextBook(2, "Koko");
            var result = library.LoanTextBook(2, "Koko");
            Assert.AreEqual($"Koko still hasn't returned {text1.Title}!", result);
        }
        [Test]
        public void ReturnTextBookShouldWorkCorrectly()
        {
            UniversityLibrary library = new UniversityLibrary();
            TextBook text = new TextBook("roman", "S.King", "horror");
            library.AddTextBookToLibrary(text);
            TextBook text1 = new TextBook("SomeText", "Ivan", "humor");
            library.AddTextBookToLibrary(text1);
            library.LoanTextBook(2, "Koko");
            var result = library.ReturnTextBook(2);
            Assert.AreEqual($"SomeText is returned to the library.", result);
            Assert.IsEmpty(text1.Holder);
        }
    }
}