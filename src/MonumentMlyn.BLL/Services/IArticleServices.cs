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
        Task<ArticleDto> GetArticleById(Guid idArticle);
        Task CreateArticle(ArticleRequest article);
        Task UpdateArticle(Guid idArticle, ArticleRequest article);
        Task DeleteArticle(Guid idArticle);
    }
}