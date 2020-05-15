using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZadanieAngular.Models;

namespace ZadanieAngular.Data
{
    public class FootballerContext : DbContext
    {
        public FootballerContext(DbContextOptions<FootballerContext> options) : base(options) { }

        public DbSet<Footballer> Footballers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BazaFootballers.db");
        }
    }
}
