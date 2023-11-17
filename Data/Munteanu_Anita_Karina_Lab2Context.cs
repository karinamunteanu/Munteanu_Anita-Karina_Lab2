using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Munteanu_Anita_Karina_Lab2.Models;

namespace Munteanu_Anita_Karina_Lab2.Data
{
    public class Munteanu_Anita_Karina_Lab2Context : DbContext
    {
        public Munteanu_Anita_Karina_Lab2Context (DbContextOptions<Munteanu_Anita_Karina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Munteanu_Anita_Karina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Munteanu_Anita_Karina_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
