using Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        void AddArticle(AddArticleRequest reqModel);
        void DeleteArticle(DeleteArticleArticleRequest reqModel);
        void FindArticle(FindArticleRequest reqModel);
        void GetArticle(GetArticleRequest reqModel);
        void UpdateArticle(UpdateArticleRequest reqModel);

        GetAllArticleResponse GetAllArticles();
        GetArticleResponse GetArticle(int id);
        SearchArticleResponse SearchArticle(string keyword);
    }
}
