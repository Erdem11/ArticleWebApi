using DataAccess.Repository;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DatabaseContext _dbContext;
        private DbSet<T> _objectSet;

        public Repository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _objectSet = _dbContext.Set<T>();
        }

        public T Add(T entity)
        {
            _objectSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T Delete(int id)
        {
            var deleted = _objectSet.FirstOrDefault(x => x.Id == id);
            _objectSet.Remove(deleted);
            _dbContext.SaveChanges();
            return deleted;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.Where(predicate);
        }

        public T Get(int id)
        {
            return _objectSet.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return _objectSet.AsNoTracking();
        }

        public T Update(T entity)
        {
            _objectSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
