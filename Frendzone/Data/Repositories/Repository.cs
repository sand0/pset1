using Frendzone.Data.Interfaces;
using Frendzone.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        protected DbSet<T> Entities;
        protected string ErrorMessage = string.Empty;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            Entities = context.Set<T>();
        }

        public IEnumerable<T> All() => Entities;


        public T Get(int id) => Entities.SingleOrDefault(e => e.Id == id);
        

        public T Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            Entities.Add(entity);
            _context.SaveChanges();
            return entity;
        }


        public T Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }


        public bool Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            if (Entities.Contains(entity))
            {
                Entities.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
