using System.Collections.Generic;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class FilmManager : IFilmService
    {
        private IFilmRepository _filmRepository;

        public FilmManager(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

       

        public List<Film> AnasayfaFilmleriAl()
        {
            return _filmRepository.AnasayfaFilmleriAl();
        }

        public List<Film> AramaSonucGetir(string araYaz)
        {
           return _filmRepository.AramaSonucGetir(araYaz);
        }

       

        public bool Ekle(Film entity)
        {
            // void i bool olarak değiştirmemizin sebebi web katmanının bilmesi için.
            // bu metodu admin controller de ki film ekle metodunda kullanalım

            if(Dogrulama(entity))
            {
                _filmRepository.Ekle(entity);

                return true;
            }
            return false;
           
        }

        public Film FilmDetayGetir(string url)
        {
            return _filmRepository.FilmDetayGetir(url);
        }

        public List<Film> FilmKategoriIdGetir(string name,int page,int pageSize)
        {
          return _filmRepository.FilmKategoriIdGetir(name,page,pageSize);
        }

        public List<Film> GetAll()
        {
           return _filmRepository.GetAll();
        }

        public Film GetById(int id)
        {
           return _filmRepository.GetById(id);
        }

        public int GetCauntByKategori(string kategori)
        {
            return _filmRepository.GetCauntByKategori(kategori);
        }

        public void Sil(Film entity)
        {
             _filmRepository.Sil(entity);
        }

        public void Update(Film entity)
        {
           
            _filmRepository.Update(entity);
        }

        public bool Update(Film entity, int[] kategoriIdler)
        {
            if(Dogrulama(entity))
            {
                if(kategoriIdler.Length == 0)
                {
                    HataMesaji+= "En az bir kategori seçmelisiniz...";
                    return false;
                    //burada güncelleme sayfasında eğer kullancı kategori seçimi yapmamışsa 
                    //hata mesajı gönderiyoruz.Yapmışsa aşağıda metdoumuz çalışır(length 0 ise seçim olmamış demektir)
                }
               _filmRepository.Update(entity,kategoriIdler);

                return true;
            }
            return false;
           
          
        }

        public Film İdİleKategori(int id)
        {
           return _filmRepository.İdİleKategori(id);
        }

        public string HataMesaji { get;set;}

         public bool Dogrulama(Film entity) 
        {
          var İsGecerli = true;

          if(string.IsNullOrEmpty(entity.Name))
          {
              HataMesaji += "Bir film adı girmelisiniz. \n";
              İsGecerli = false;
          }

           if(entity.Sene < 0)
          {
              HataMesaji += "Yılı doğru giriniz.\n";
              İsGecerli = false;
          }

          return İsGecerli;

        //   şimdi oluşturduğumuz validationu istediğimiz metod içinde kullanabiliriz
        }

    }
}