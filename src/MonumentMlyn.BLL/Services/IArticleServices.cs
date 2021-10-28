using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Article;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IArticleServices
    {
        Task<IEnumerable<ArticleDto>> GetAllArticles();
        Task<ArticleDto> GetArticleById(Guid articleId);
        Task CreateArticle(ArticleRequest article);
        Task UpdateArticle(Guid articleId, ArticleRequest article);
        Task DeleteArticle(Guid articleId);
        Task AddPhoto(Guid articleId, Guid photoId);
        Task<IEnumerable<ArticleDto>> GetPhotoByArticle(Guid articleId);
        Task<IEnumerable<ArticleDto>> GetAllPhotoByArticle();
        Task UpdatePhotoByArticle(Guid articleId, ArticleRequest article);
        Task DeletePhotoByArticle(Guid articleId, ArticleRequest article);



    }
}