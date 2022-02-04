using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class StarModel
    {
      public int StarId { get; set; }  
      public string FullName { get; set; }
      public string Starİmage { get; set; }

      public List<Star> Stars{get; set;}
    }
}