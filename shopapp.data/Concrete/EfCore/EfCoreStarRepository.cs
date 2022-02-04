using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreStarRepository : EfCoreGenericRepository<Star, ShopContext>, IStarRepository
    {
        public Star StarAbout(int id)
        {
           using(var context = new ShopContext())
           {
               return context.Stars
                                             .Where(i=>i.StarId==id)
                                             .FirstOrDefault();

               
           }

          
        }
    }
}