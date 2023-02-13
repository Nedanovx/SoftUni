using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }
        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;
            List<Book> books;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                books.Sort();
            }
            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
             
            }

            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
