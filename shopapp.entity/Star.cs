using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.entity
{
    public class Star
    {
      public int StarId { get; set; }  
      public string FullName { get; set; }
      public string Starİmage { get; set; }
      public string Description { get; set; }

      public string StarringMovies { get; set; }
      public int Birthyear { get; set; }
    }
}