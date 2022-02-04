using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IStarService :IValidator<Star> 
    {
           Star GetById(int id);
           List<Star> GetAll();
         
           void Ekle(Star entity);
           void Update(Star entity);
           void Sil(Star entity);

           Star StarAbout(int id);
           
    }
}