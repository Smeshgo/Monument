using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IArticleRepository : IRepositoryBase<Article>
    {
        
        Task<IEnumerable<Article>> GetAllArticles(bool trackChanges);
        Task<Article> GetArticleById(int idarticle);
        Article GetArticleWithDetails(int idarticle);
        void CreateArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(Article article);
    }
}