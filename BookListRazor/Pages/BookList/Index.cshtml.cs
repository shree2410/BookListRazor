using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;//object of an application dbcontext
        //create ctor (this one we are getting using dependency injection)
        //this applicationdbcontext we are getting through dependency injection concept
        public IndexModel(ApplicationDbContext db)
        {
            
        }
        //to return list/ienumerable books ,use getter setter mtd
        public IEnumerable<Book> Books { get; set; }
        //books is all of the books from the db
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}
