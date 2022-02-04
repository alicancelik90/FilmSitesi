using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IFilmRepository:IRepository<Film>
    {
       Film FilmDetayGetir(string url);

       List<Film> FilmKategoriIdGetir(string name,int page,int pageSize);
     
       int GetCauntByKategori(string kategori);

       List<Film> AnasayfaFilmleriAl();

       List<Film> AramaSonucGetir(string araYaz);

       Film İdİleKategori(int id);

       void Update(Film entity,int[] kategoriIdler);

   

      

      


    }
}