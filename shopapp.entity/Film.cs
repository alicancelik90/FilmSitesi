using System.Collections.Generic;

namespace shopapp.entity
{
    public class Film
    {
        public int FilmId { get; set; }
        
        public string Name { get; set; }
        public string Url { get; set; }
        public int? Sene { get; set; }
        public string Description { get; set; }
        public bool Gosterim { get; set; }
            
        public bool AnasayfaGosterim { get; set; }

      
        public string ResimUrl { get; set; }
        public int KategoriId { get; set; }

        public List<FilmKategori> FilmKategoriler { get; set; }
        public List<Comment> Comments { get; set; }
    }
}