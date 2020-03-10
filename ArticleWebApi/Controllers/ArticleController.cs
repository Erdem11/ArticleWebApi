using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [Route("~/api/Article/GetAll")]
        [HttpGet]
        public ArticleListResponse GetAll(int id)
        {
            return _articleService.GetAllArticles();
        }

        [Route("~/api/Article/Get")]
        [HttpGet]
        public ArticleResponse Get(int id)
        {
            return _articleService.Get(id);
        }

        [Route("~/api/Article/Search")]
        [HttpGet]
        public ArticleListResponse Search(string keyword)
        {
            return _articleService.Search(keyword);
        }

        [Route("~/api/Article/AddArticle")]
        [HttpPost]
        public ArticleResponse AddArticle([FromBody] AddArticleRequest reqModel)
        {
            return _articleService.AddArticle(reqModel);
        }

        [Route("~/api/Article/Update")]
        [HttpPost]
        public ArticleResponse Update(UpdateArticleRequest request)
        {
            return _articleService.UpdateArticle(request);            
        }

        [Route("~/api/Article/Delete")]
        [HttpPost]
        public ArticleResponse Delete(int id)
        {
            return _articleService.DeleteArticle(id);
        }
    }
}
