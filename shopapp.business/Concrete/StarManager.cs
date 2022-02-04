using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class StarManager : IStarService
    {
        private IStarRepository _starRepository;
        public StarManager(IStarRepository starRepository)
        {
            _starRepository = starRepository;
        }

        public string HataMesaji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Dogrulama(Star entity)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Star entity)
        {
            throw new NotImplementedException();
        }

        public List<Star> GetAll()
        {
            return _starRepository.GetAll();
        }


        public Star GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Sil(Star entity)
        {
            throw new NotImplementedException();
        }

        public Star StarAbout(int id)
        {
            return _starRepository.StarAbout(id);
        }

        public void Update(Star entity)
        {
            throw new NotImplementedException();
        }
    }
}