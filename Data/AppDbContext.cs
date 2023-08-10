using LibraryBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livre>()
                .HasOne(e => e.Auteur)
                .WithMany(e => e.Livres)
                .HasForeignKey(e => e.IdAut)
                .IsRequired();
    
            modelBuilder.Entity<Livre>()
                .HasOne(e => e.Theme)
                .WithMany(e=>e.Livres)
                .HasForeignKey(e=>e.IdTheme)
                .IsRequired();
            
            modelBuilder.Entity<Section>() 
                .HasOne(e=>e.Livre)
                .WithMany(e=>e.Sections)
                .HasForeignKey(e=>e.IdLivre)
                .IsRequired();
        }
    }
}
