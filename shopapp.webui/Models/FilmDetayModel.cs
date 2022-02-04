using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class FilmDetayModel
    {
        public Film Film { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Comment> Comments { get; set; }
        
    }
}