using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IArticleServices
    {
        Task<IEnumerable<ArticleDto>> GetAllArticles();
        Task<ArticleDto> GetArticleById(Guid idArticle);
        Task CreateArticle(ArticleDto article);
        Task UpdateArticle(Guid idArticle, ArticleDto article);
        Task DeleteArticle(Guid idArticle);
    }
}