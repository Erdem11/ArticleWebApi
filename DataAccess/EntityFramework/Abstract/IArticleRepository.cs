using DataAccess.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Abstract
{
    public interface IArticleRepository<T>: IRepository<T> where T: EntityBase
    {
    }
}
