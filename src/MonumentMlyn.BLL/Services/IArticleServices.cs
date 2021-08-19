using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IArticleServices
    {
        Task<IEnumerable<ArticleDto>> GetAllArticles(bool trackChanges);
        Task<ArticleDto> GetArticleById(int idArticle);
        Task CreateArticle(ArticleDto article);
        Task UpdateArticle(int idArticle, ArticleDto article);
        Task DeleteArticle(int idArticle);
    }
}