using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;

namespace shopapp.ViewComponents
{
      
    public class KategorilerViewComponent : ViewComponent
    {
        private IKategoriService _kategoriService;
        
        public KategorilerViewComponent(IKategoriService kategoriService)
        {
            this._kategoriService = kategoriService;
        }
       public IViewComponentResult Invoke()
       { 
          
             if (RouteData.Values["kategori"]!=null)
                ViewBag.SelectedCategory = RouteData?.Values["kategori"];
      
               


            return View(_kategoriService.GetAll());
           
       }
    }
}