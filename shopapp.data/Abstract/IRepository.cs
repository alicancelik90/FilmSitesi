using System.Collections.Generic;

namespace shopapp.data.Abstract
{
    public interface IRepository<T>
    {
         T GetById(int id);
         List<T> GetAll();

         void Ekle(T entity);
         void Update(T entity);
         void Sil(T entity);

    }
}