using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class FilmCommentModel
    {
        public int CommentId { get; set; }
        public string CommentString { get; set; }
        public decimal CommentPoint { get; set; }
        public Film Film { get; set; }
      
        public List<Comment> Comments { get; set; }
    }
}