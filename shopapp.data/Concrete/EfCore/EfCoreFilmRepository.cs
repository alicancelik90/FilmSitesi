using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreFilmRepository : EfCoreGenericRepository<Film, ShopContext>, IFilmRepository
    {
      
        public Film FilmDetayGetir(string url)
        {
            
           using(var context = new ShopContext())
            {
              return context.Filmler
                                    .Where(i=>i.Url==url)
                                    .Include(i=>i.FilmKategoriler)
                                    .ThenInclude(i=>i.Kategori)
                                    .FirstOrDefault();
            }
        }

        public List<Film> FilmKategoriIdGetir(string name,int page,int pageSize)
        {
          using(var context = new ShopContext())
           {
             var filmler = context.Filmler.Where(i=>i.Gosterim).AsQueryable();
             if (!string.IsNullOrEmpty(name))
             {
                 filmler = filmler
                                  .Include(i=>i.FilmKategoriler)
                                  .ThenInclude(i=>i.Kategori)
                                  .Where(i=>i.FilmKategoriler.Any(a=>a.Kategori.Url==name));
             }
             return filmler.Skip((page-1)*pageSize).Take(pageSize).ToList();
           }
        }

        public int GetCauntByKategori(string kategori)
        {
           using(var context = new ShopContext())
           {
             var filmler = context.Filmler.Where(i=>i.Gosterim).AsQueryable();
             if (!string.IsNullOrEmpty(kategori))
             {
                 filmler = filmler
                                  .Include(i=>i.FilmKategoriler)
                                  .ThenInclude(i=>i.Kategori)
                                  .Where(i=>i.FilmKategoriler.Any(a=>a.Kategori.Url==kategori));
             }
             return filmler.Count();
           }
        }

        public List<Film> AnasayfaFilmleriAl()
        {
           using(var context = new ShopContext())
            {
              return context.Filmler
                                    .Where(i=>i.Gosterim && i.AnasayfaGosterim).ToList();
                                    
                                   
            }
        }

        public List<Film> AramaSonucGetir(string araYaz)
        {
            using(var context = new ShopContext())
            {
              var filmler = context
                            .Filmler
                            .Where(i=> i.Gosterim && (i.Name.ToLower().Contains(araYaz)|| i.Description.ToLower().Contains(araYaz)));
                                    
              return filmler.ToList();                     
            }
          
        }

        public Film İdİleKategori(int id)
        {
             using(var context = new ShopContext())
            {
              return context.Filmler
                                    .Where(i=>i.FilmId==id)
                                    .Include(i=>i.FilmKategoriler)
                                    .ThenInclude(i=>i.Kategori)
                                    .FirstOrDefault();
            }
        }

        public void Update(Film entity, int[] kategoriIdler)
        {
            using(var context = new ShopContext())
            {
              var film = context.Filmler
                                    
                                    .Include(i=>i.FilmKategoriler)
                                    .FirstOrDefault(i=>i.FilmId == entity.FilmId);
              
              if (film!=null)
              {
                  film.Name = entity.Name;
                  film.Sene = entity.Sene;
                  film.Description = entity.Description;
                  film.Url = entity.Url;
                  film.ResimUrl = entity.ResimUrl;
                  film.Gosterim = entity.Gosterim;
                  film.AnasayfaGosterim = entity.AnasayfaGosterim;

                  film.FilmKategoriler=kategoriIdler.Select(katid => new FilmKategori()
                  {
                      FilmId = entity.FilmId,
                      KategoriId = katid
                  }).ToList();

                 context.SaveChanges();

              }

            }
            
        }

      
    }

}  
    
    

