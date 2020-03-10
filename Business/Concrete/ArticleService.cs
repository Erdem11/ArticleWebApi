using Business.Abstract;
using Business.ViewModels;
using DataAccess.EntityFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public ArticleResponse AddArticle(AddArticleRequest reqModel)
        {
  
            return new ArticleResponse { Article = _articleRepository.Add(reqModel.Article) };
        }

        public ArticleResponse DeleteArticle(int id)
        {
            return new ArticleResponse { Article = _articleRepository.Delete(id) };
        }

        public ArticleResponse Get(int id)
        {
            return new ArticleResponse { Article = _articleRepository.Get(id) };
        }

        public ArticleListResponse GetAllArticles()
        {
            return new ArticleListResponse { Articles = _articleRepository.GetAll().ToList() };
        }

        public ArticleListResponse Search(string keyword)
        {
            return new ArticleListResponse
            {
                Articles = _articleRepository.Find(
                    x =>
                    x.Content.ToLower().Contains(keyword.ToLower()) ||
                    x.Title.ToLower().Contains(keyword.ToLower())).ToList()
            };
        }

        public ArticleResponse UpdateArticle(UpdateArticleRequest reqModel)
        {
            return new ArticleResponse { Article = _articleRepository.Update(reqModel.Article) };
        }
    }
}
