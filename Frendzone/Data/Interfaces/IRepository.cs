using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> All();
        T Get(int id);

        T Create(T entity);
        T Update(T entity);
        bool Delete(T entity);

        void Save();
    }
}
