using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.entity;

using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
  

    public class AdminController :Controller
    {
       private IFilmService _filmService;
       private IKategoriService _kategoriService;
       private IStarService _starService;
       
      
       public AdminController(IFilmService filmService, IKategoriService kategoriService, IStarService starService)
       {
           _filmService = filmService;
           _kategoriService = kategoriService;
           _starService = starService;
         
         
       }

      
       
       
       public IActionResult FilmListe()
       {
           return View(new FilmListeViewModel()
           {
               Filmler = _filmService.GetAll()
           });
       }

         public IActionResult KategoriListe()
       {
           return View(new KategoriListeViewModel()
           {
               Kategoriler = _kategoriService.GetAll()
           });
       }

       [HttpGet]
       public IActionResult FilmEkle()
       {
           return View();

       }
       [HttpPost]
        public IActionResult FilmEkle(FilmModel model)
       {
           var entity = new Film()
           {
               Name =model.Name,
               Description =model.Description,
               Url =model.Url,
               ResimUrl = model.ResimUrl,
               Sene = model.Sene 
           };

           if(_filmService.Ekle(entity))
           {
               MesajEkle("Film eklendi...","succes");

               return RedirectToAction("FilmListe");
           }
            MesajEkle(_filmService.HataMesaji,"danger");
            // en aşağıda private bir metod oluşturduk ona göre düzenledik burayıs
          
          
           return View(model);

            
           
       }

        [HttpGet]
       public IActionResult KategoriEkle()
       {
           return View();

       }
       [HttpPost]
       public IActionResult KategoriEkle(KategoriModel model)
       {
           var entity = new Kategori()
           {
               Name =model.Name,
            
               Url =model.Url,
            
           };

           _kategoriService.Ekle(entity);

             var msg = new AlertMessage()
           {
               Message = $"{entity.Name} isimli kategori eklendi...",
               AlertType ="warning"
           };
           TempData["message"] = JsonConvert.SerializeObject(msg);

           return RedirectToAction("KategoriListe");
           
       }

       [HttpGet]
       public IActionResult FilmDuzenle(int? id)
       {
           if (id==null)
           {
               return NotFound();
           }
           var entity = _filmService.İdİleKategori((int)id);
           if (entity==null)
           {
                return NotFound();
           }
           var model = new FilmModel()
           {
               FilmId = entity.FilmId,
               Name = entity.Name,
               Sene = entity.Sene,
               Url = entity.Url,
               Description = entity.Description,
               ResimUrl = entity.ResimUrl,
               Gosterim = entity.Gosterim,
               AnasayfaGosterim = entity.AnasayfaGosterim,
               KategoriSecim = entity.FilmKategoriler.Select(i=>i.Kategori).ToList()
           };

           ViewBag.Kategoriler = _kategoriService.GetAll();
           
           return View(model);

       }
       [HttpPost]
        public IActionResult FilmDuzenle(FilmModel model,int[] kategoriIdler)
       {
           var entity = _filmService.GetById(model.FilmId);
           if (entity == null)
           {
               return NotFound();
           }
           entity.Name = model.Name;
           entity.Sene = model.Sene;
           entity.Url = model.Url;
           entity.ResimUrl = model.ResimUrl;
           entity.Description = model.Description;
           entity.Gosterim = model.Gosterim;
           entity.AnasayfaGosterim = model.AnasayfaGosterim;
           
           if(_filmService.Update(entity,kategoriIdler))
           {
               MesajEkle("Film güncellendi...","succes");

               return RedirectToAction("FilmListe");
           }
            MesajEkle(_filmService.HataMesaji,"danger");
            // en aşağıda private bir metod oluşturduk ona göre düzenledik burayı
          
           ViewBag.Kategoriler = _kategoriService.GetAll();
           return View(model);

         
           
       }

        [HttpGet]
       public IActionResult KategoriDuzenle(int? id)
       {
           if (id==null)
           {
               return NotFound();
           }
           var entity = _kategoriService.GetByIdWithFilmler((int)id);
           if (entity==null)
           {
                return NotFound();
           }
           var model = new KategoriModel()
           {
               KategoriId = entity.KategoriId,
               Name = entity.Name,
               Url = entity.Url,
               Filmler = entity.FilmKategoriler.Select(i=>i.Film).ToList()
             
           };
           return View(model);

       }
       [HttpPost]
        public IActionResult KategoriDuzenle(KategoriModel model)
       {
           var entity = _kategoriService.GetById(model.KategoriId);
           if (entity == null)
           {
               return NotFound();
           }
           entity.Name = model.Name;
           entity.Url = model.Url;
        
           _kategoriService.Update(entity);

           var msg = new AlertMessage()
           {
               Message = $"{entity.Name} isimli kategori güncellendi...",
               AlertType ="success"
           };
           TempData["message"] = JsonConvert.SerializeObject(msg);

           return RedirectToAction("KategoriListe");
           
       }

       public IActionResult FilmSil(int filmId)
       {
           var entity = _filmService.GetById(filmId);
           if (entity!=null)
           {
               _filmService.Sil(entity);
           }

           return RedirectToAction("FilmListe");
       }

        public IActionResult KategoriSil(int kategoriId)
       {
           var entity = _kategoriService.GetById(kategoriId);
           if (entity!=null)
           {
               _kategoriService.Sil(entity);
           }

           var msg = new AlertMessage()
           {
               Message = $"{entity.Name} isimli kategori silindi...",
               AlertType ="danger"
           };
           TempData["message"] = JsonConvert.SerializeObject(msg);

           return RedirectToAction("KategoriListe");
       }

       [HttpPost]
       public IActionResult KategoridenSil(int filmId,int kategoriId)
       {
           _kategoriService.KategoridenSil(filmId,kategoriId);
           
           return Redirect("/admin/kategoriler/"+kategoriId);
           
       }

       public IActionResult StarList()
       {
         
           return View(new StarModel()
           {
               Stars = _starService.GetAll()
           });
       }

       private void MesajEkle(string mesaj,string alerttype)
       {
            var msg = new AlertMessage()
               {
                 Message =mesaj,
                 AlertType= alerttype
               };

               TempData["message"] = JsonConvert.SerializeObject(msg);

       }
        
    }
}