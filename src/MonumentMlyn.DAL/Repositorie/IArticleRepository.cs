using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IArticleRepository : IRepositoryBase<Article>
    {
        
        Task<IEnumerable<Article>> GetAllArticles(bool trackChanges);
        Task<Article> GetArticleById(Guid idarticle);
        Article GetArticleWithDetails(Guid idarticle);
        void CreateArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(Article article);
    }
}