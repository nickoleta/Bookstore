using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksStore.Data
{
    public interface IBookData
    {
        IEnumerable<string> GetBooksByName(string name);
    }

    public class InMemoryBookData : IBookData
    {
        readonly List<string> Books;

        public InMemoryBookData()
        {
            Books = new List<string>()
            {
                new string("Pride"),
                new string("The little prince"),
                new string("White trash")
            };
        }

        public IEnumerable<string> GetBooksByName(string name = null)
        {
            return from book in Books
                   where string.IsNullOrEmpty(name) || book.StartsWith(name)
                   orderby book
                   select book;
        }
    }
}
