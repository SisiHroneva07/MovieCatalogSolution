using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.Data.Models;

namespace MovieCatalog.Data
{
    public class MovieCatalogDbContext : DbContext
    {
        public MovieCatalogDbContext(DbContextOptions<MovieCatalogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

