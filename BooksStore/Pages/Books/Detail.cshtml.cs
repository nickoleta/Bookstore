using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksStore.Pages.Books
{
    public class DetailModel : PageModel
    {
        public string Book { get; set; }

        public IActionResult OnGet(string bookName)
        {
            Book = "Pride";

            if(Book == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
