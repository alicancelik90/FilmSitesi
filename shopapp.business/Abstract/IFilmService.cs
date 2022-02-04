using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IFilmService :IValidator<Film> 
    {
         Film GetById(int id);
         Film FilmDetayGetir(string url);
         List<Film> FilmKategoriIdGetir(string name,int page,int pageSize); 
         List<Film> AnasayfaFilmleriAl();
         List<Film> AramaSonucGetir(string araYaz);
         List<Film> GetAll();

         bool Ekle(Film entity);
         void Update(Film entity);
         void Sil(Film entity);
         int  GetCauntByKategori(string kategori);
         Film İdİleKategori(int id);
         bool Update(Film entity,int[] kategoriIdler);
      

         
       
    }
}