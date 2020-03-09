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

        public int Add(T entity)
        {
            _objectSet.Add(entity);
            return _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _objectSet.Remove(_objectSet.FirstOrDefault(x => x.Id == id));
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

        public void Update(T entity)
        {
            _objectSet.Update(entity);
        }
    }
}
