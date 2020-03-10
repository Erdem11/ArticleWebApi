using DataAccess.EntityFramework.Abstract;
using DataAccess.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Concrete
{
    public class ArticleRepository: Repository<Article>, IArticleRepository
    {
        public ArticleRepository(DatabaseContext dbContext): base(dbContext)
        {

        }
    }
}
