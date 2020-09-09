using System;
using System.ComponentModel.DataAnnotations;

namespace BooksStore.Core
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public Book(string Name, string Author, string Description)
        {
            this.Name = Name;
            this.Author = Author;
            this.Description = Description;
        }
    }
}
