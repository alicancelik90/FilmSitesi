using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IKategoriRepository :IRepository<Kategori>
    {
        
         Kategori GetByIDWithFilmler(int kategoriId);
         void KategoridenSil(int filmId,int kategoriId);
    }
}