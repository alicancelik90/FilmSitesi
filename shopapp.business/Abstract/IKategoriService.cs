using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IKategoriService : IValidator<Kategori>
    {
         Kategori GetById(int id);
         List<Kategori> GetAll();
         Kategori GetByIdWithFilmler(int kategoriId);

         void Ekle(Kategori entity);
         void Update(Kategori entity);
         void Sil(Kategori entity); 
         void KategoridenSil(int filmId,int kategoriId);
    }
}