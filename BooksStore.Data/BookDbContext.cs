using System;
using BooksStore.Core;
using Microsoft.EntityFrameworkCore;

namespace BooksStore.Data
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
                
        }
    }
}
