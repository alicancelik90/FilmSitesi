using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.webui.Models;

namespace MVC_Film_Örnek_Uygulama.Controllers
{
    public class AnasayfaController : Controller
    {
        private IFilmService _filmService;
        
        public AnasayfaController(IFilmService filmService)
        {
            this._filmService = filmService;
        }
        

        
        public IActionResult Ana()
        { 
            
          
            var filmViewModel = new FilmListeViewModel()
            {
                Filmler = _filmService.AnasayfaFilmleriAl()
              
            };

            return View(filmViewModel);
        }

      

        
    }
}

    

