using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Models;


namespace shopapp.webui.Controllers
{
    public class FilmSitesiController :Controller
    {
        
        private IFilmService _filmService;
        private IStarService _starService;
        private ICommentService _commentService;
        
        public FilmSitesiController(IFilmService filmService,ICommentService commentService,IStarService starService)
        {
            this._filmService = filmService;
            this._commentService = commentService;
            this._starService = starService;
        }

         public IActionResult Liste(string kategori,int page =1)
        {   
            const int pageSize = 2;
            var filmViewModel = new FilmListeViewModel()
            {
                PageInfo = new PageInfo(){
                    TotalItems = _filmService.GetCauntByKategori(kategori),
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentKategori = kategori

                },

                Filmler = _filmService.FilmKategoriIdGetir(kategori,page,pageSize)
              
            };

            return View(filmViewModel);
        }

        public IActionResult Detay(string url)
        {
            if (url == null)
            {
                return NotFound();
               
            }

            Film film = _filmService.FilmDetayGetir(url);

            if (film==null)
            {
                return NotFound();
            } 

            return View(new FilmDetayModel{
                Film = film,
                Kategoriler = film.FilmKategoriler.Select(i=>i.Kategori).ToList()
            });
        }

        public IActionResult Ara(string q)
        {
           
            var filmViewModel = new FilmListeViewModel()
            {
                Filmler = _filmService.AramaSonucGetir(q)
              
            }; 

            return View(filmViewModel);
        }

        public IActionResult StarTheAbout(int id)
        {
           Star star = _starService.StarAbout(id);

           return View(new StarAboutModel()
           {
              Star = star
           });

        }
        [HttpGet]
        public IActionResult CommentCreate()
        {
           return View();
        }

        [HttpPost]
        public IActionResult CommentCreate(FilmCommentModel model)
        {
          var entity = new Comment()
            {
               CommentPoint = model.CommentPoint,

               CommentString = model.CommentString
            };

            _commentService.Ekle(entity);

            return RedirectToAction("UserComments");
             
        }

        public IActionResult UserComments()
        {
            return View();
        }

        

    }

     
}