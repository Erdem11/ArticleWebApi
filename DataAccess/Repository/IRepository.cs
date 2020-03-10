using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Repository
{
    public interface IRepository<T> where T: EntityBase
    {
        T Add(T entity);
        T Get(int id);
        T Update(T entity);
        T Delete(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
