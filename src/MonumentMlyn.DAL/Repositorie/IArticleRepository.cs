using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IArticleRepository : IRepositoryBase<Article>
    {
        
        Task<IEnumerable<Article>> GetAllArticles(bool trackChanges);
        Task<Article> GetArticleById(Guid articleId);
        Article GetArticleWithDetails(Guid articleId);
        void CreateArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(Article article);
        IEnumerable<Article> GetPhotoByArticle(Guid articleId);
        IEnumerable<Article> GetAllPhotoByArticle();
        Task UpdatePhotoByArticle(Guid articleId, Guid photoIdO, Guid photoIdNew);
        Task DeletePhotoByArticle(Guid articleId, Guid photoId);
    }
}