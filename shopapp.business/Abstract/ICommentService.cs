using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface ICommentService
    {
         void Ekle(Comment entity);
         void Update(Comment entity);
         void Sil(Comment entity);
    }
}