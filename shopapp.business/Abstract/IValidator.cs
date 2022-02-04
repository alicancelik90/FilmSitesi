using System.Collections.Generic;
using shopapp.entity;


namespace shopapp.business.Abstract
    {

    public interface IValidator<T>
    {
       string HataMesaji { get; set; }

       bool Dogrulama(T entity);
    }


      
   }
