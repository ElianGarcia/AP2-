using ArticlesApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlesApp.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLExpress; Database=ArticulosDB; Trusted_Connection= True;");
        }
    }
}
