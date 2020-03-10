using Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        ArticleListResponse GetAllArticles();
        ArticleResponse Get(int id);
        ArticleListResponse Search(string keyword);

        ArticleResponse AddArticle(AddArticleRequest reqModel);
        ArticleResponse UpdateArticle(UpdateArticleRequest reqModel);
        ArticleResponse DeleteArticle(int id);
    }
}
