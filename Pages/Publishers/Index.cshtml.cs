using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Munteanu_Anita_Karina_Lab2.Data;
using Munteanu_Anita_Karina_Lab2.Models;

namespace Munteanu_Anita_Karina_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Munteanu_Anita_Karina_Lab2.Data.Munteanu_Anita_Karina_Lab2Context _context;

        public IndexModel(Munteanu_Anita_Karina_Lab2.Data.Munteanu_Anita_Karina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
