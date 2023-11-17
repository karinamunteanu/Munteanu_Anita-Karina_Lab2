using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Munteanu_Anita_Karina_Lab2.Data;
using Munteanu_Anita_Karina_Lab2.Models;

namespace Munteanu_Anita_Karina_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Munteanu_Anita_Karina_Lab2.Data.Munteanu_Anita_Karina_Lab2Context _context;

        public IndexModel(Munteanu_Anita_Karina_Lab2.Data.Munteanu_Anita_Karina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;
        public IList<SelectListItem> AuthorList { get; set; } = new List<SelectListItem>();

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                 .Include(b => b.Publisher)
                 .ToListAsync();

            var authors = await _context.Set<Author>().ToListAsync();

            AuthorList = authors.Select(author =>
                new SelectListItem
                {
                    Value = author.ID.ToString(),
                    Text = $"{author.FirstName} {author.LastName}"
                }).ToList();

        }
}
}



