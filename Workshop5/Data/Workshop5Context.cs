using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workshop5.Models;

namespace Workshop5.Data
{
    public class Workshop5Context : DbContext
    {
        public Workshop5Context (DbContextOptions<Workshop5Context> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Nota> Nota { get; set; }
    }
}
