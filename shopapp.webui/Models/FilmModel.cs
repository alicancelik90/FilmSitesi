using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class FilmModel
    {
        public int FilmId { get; set; }
        public string Name { get; set; }
        public int? Sene { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string ResimUrl { get; set; }
        public bool Gosterim { get; set; }
        public bool AnasayfaGosterim { get; set; }
        public List<Kategori> KategoriSecim { get; set; }

        public List<Comment> Comments { get; set; }
       

        
    }
}