using LibraryBook.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBook.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Auteur>Auteurs { get; set;}
        public DbSet<Theme> Themes { get; set; }   
        public DbSet<Section> Sections { get; set; }

    }
}
