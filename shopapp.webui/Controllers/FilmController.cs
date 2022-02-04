using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;
using System;

namespace shopapp.webui.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private IFilmService _filmService;
        
        public FilmController(IFilmService filmService)
        {
            this._filmService = filmService;
        }
        public IEnumerable<Film> Get()
        {
            try {
            var list = _filmService.GetAll();

            return list;
            } catch(Exception e) {
                Console.WriteLine(e);
                return _filmService.GetAll();
            }
        }
    }
}