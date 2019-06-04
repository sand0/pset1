using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Data.Interfaces
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> All();
        T Get(int id);
        T Insert(T entity);
        T Update(T entity);
        bool Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
