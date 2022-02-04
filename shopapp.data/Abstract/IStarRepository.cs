using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IStarRepository : IRepository<Star>
    {
        Star StarAbout(int id);
    }
}