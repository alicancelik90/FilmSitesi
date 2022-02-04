using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class KategoriModel
    {
        public int KategoriId { get; set; }
       
        
        public string Name { get; set; }
        
        public string Url { get; set; }
        public List<Film> Filmler { get; set; }

    }
}