using System;
using System.Collections.Generic;
using BooksStore.Data;
using BooksStore.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace BooksStore.Pages.Books
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IBookData bookData;

        public IEnumerable<Book> Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, IBookData bookData)
        {
            this.config = config;
            this.bookData = bookData;
        }

        // responds to /Books/List requests
        public void OnGet()
        {
            Books = bookData.GetBooksByName(SearchTerm);
        }
    }
}
