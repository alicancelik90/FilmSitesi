using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreKategoriRepository : EfCoreGenericRepository<Kategori, ShopContext>, IKategoriRepository
    {
        public Kategori GetByIDWithFilmler(int kategoriId)
        {
            using (var context = new ShopContext())
            {
                return context.Kategoriler    
                                .Where(i=>i.KategoriId == kategoriId)
                                .Include(i=>i.FilmKategoriler)
                                .ThenInclude(i=>i.Film)
                                .FirstOrDefault();
            }
        }

        public void KategoridenSil(int filmId, int kategoriId)
        {
            using (var context = new ShopContext())
            {
                var cmd = "delete from filmkategori where FilmId=@p0 and KategoriId=@p1";
                
                context.Database.ExecuteSqlRaw(cmd,filmId,kategoriId);
                                
            }
        }
    }
}