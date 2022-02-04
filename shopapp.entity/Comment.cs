using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentString { get; set; }
        public decimal CommentPoint { get; set; }
        public Film Film { get; set; }
    }
}