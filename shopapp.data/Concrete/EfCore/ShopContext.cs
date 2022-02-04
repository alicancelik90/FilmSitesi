using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class ShopContext :DbContext
    {
       
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
       
        public DbSet<FilmKategori> FilmKategoriler { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlite("Data Source=filmDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmKategori>()
            .HasKey(c=> new {c.KategoriId,c.FilmId});

         
        }
    }
}