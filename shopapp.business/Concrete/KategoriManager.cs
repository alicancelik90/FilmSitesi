using System.Collections.Generic;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private IKategoriRepository _kategoriRepository;
        public KategoriManager(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }

        public string HataMesaji { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public bool Dogrulama(Kategori entity)
        {
            throw new System.NotImplementedException();
        }

        public void Ekle(Kategori entity)
        {
             _kategoriRepository.Ekle(entity);
        }

        public List<Kategori> GetAll()
        {
           return _kategoriRepository.GetAll();
        }

        public Kategori GetById(int id)
        {
           return _kategoriRepository.GetById(id);
        }

        public Kategori GetByIdWithFilmler(int kategoriId)
        {
          return _kategoriRepository.GetByIDWithFilmler(kategoriId);
        }

        public void KategoridenSil(int filmId, int kategoriId)
        {
          _kategoriRepository.KategoridenSil(filmId,kategoriId);
        }

        public void Sil(Kategori entity)
        {
           _kategoriRepository.Sil(entity);
        }

        public void Update(Kategori entity)
        {
           _kategoriRepository.Update(entity); 
        }
    }
}