using JoelHiltonFilmCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace JoelHiltonFilmCollection.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This maps to the existing SQLite table structure
            modelBuilder.Entity<Movie>().ToTable("Movies");
        }
    }
}
