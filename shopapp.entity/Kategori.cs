using System.Collections.Generic;

namespace shopapp.entity
{
    public class Kategori
    {
        public int KategoriId { get; set; }
       
        
        public string Name { get; set; }
        
        public string Url { get; set; }

        public List<FilmKategori> FilmKategoriler { get; set; }
       

    }
}