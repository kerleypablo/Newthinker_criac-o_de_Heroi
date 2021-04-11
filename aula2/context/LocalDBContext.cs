using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aula2.entities;

namespace aula2.context
{
    public class LocalDBContext : DbContext
    {
        public LocalDBContext(DbContextOptions<LocalDBContext> opt) : base(opt)
        {

        }

        public DbSet<Produto> produto { get; set; }
        public DbSet<Categoria> categoria { get; set; }

        public DbSet<Heroi> heroi { get; set; }

        public DbSet<Fraquesa> fraquesa { get; set; }

        public DbSet<Poderes> poder { get; set; }

        public DbSet<Fantasia> fantasia { get; set; }




        /* protected override void onModelCreating(ModelBuilder modelBuilder)
         {

         }
        */

    }
}
