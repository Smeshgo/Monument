using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class ArticleRepositoryImpl : RepositoryBaseImpl<Article>, IArticleRepository
    {
        public ArticleRepositoryImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
        /// <summary>
        /// Method for get all employees from db.
        /// </summary>
        /// <returns>list of all articles.</returns>
        public async Task<IEnumerable<Article>> GetAllArticles() =>
            await FindAll()
                .OrderByDescending(c => c.UpdateArticle)
                .ToListAsync();

        /// <summary>
        /// Method for get articleId by id from db.
        /// </summary>
        /// <param name="articleId">id of Article.</param>
        /// <returns>get Article.</returns>
        public async Task<Article> GetArticleById(Guid articleId)
        {
            return await FindByCondition(x => x.ArticleId.Equals(articleId))
                .FirstOrDefaultAsync();
        }
        /// <summary>
        /// Method for get article with details from db.
        /// </summary>
        /// <param name="articleId">id of article.</param>
        /// <returns>get article with details.</returns>
        public Article GetArticleWithDetails(Guid articleId)
        {
            return FindByCondition(owner => owner.ArticleId.Equals(articleId)).FirstOrDefault();
        }
        /// <summary>
        /// Method for create article in db.
        /// </summary>
        /// <param name="article">new article.</param>
        public void CreateArticle(Article article)
        {
            Create(article);
        }
        /// <summary>
        /// Method for update article in db.
        /// </summary>
        /// <param name="article">updated article.</param>
        public void UpdateArticle(Article article)
        {
            Update(article);
        }

        public void DeleteArticle(Article article)
        {
            Delete(article);
        }

        public IEnumerable<Article> GetAllPhotoByArticle()
        {
            var result = RepositoryContext.Articles.OrderByDescending(grup => grup.UpdateArticle)
                .Include(a => a.Photos).Select(a => new Article()
                {
                    ArticleId = a.ArticleId,
                    Title = a.Title,
                    Photos = (ICollection<Photo>)a.Photos.Select(p => new Photo()
                    {
                        MinyPhoto = p.MinyPhoto
                    })
                });
            return result;
        }

    public IEnumerable<Article> GetPhotoByArticle(Guid articleId)
    {
        var result =
            RepositoryContext.Articles
                .Include(a => a.Photos).Where(b => b.ArticleId == articleId);
        return result;
    }



    public async Task UpdatePhotoByArticle(Guid articleId, Guid photoId, Guid photoIdNew)
    {
        var articleEntity = RepositoryContext.Articles.Include(p => p.Photos).FirstOrDefault(a => a.ArticleId == articleId);
        var photoOld = await RepositoryContext.Photos.FirstOrDefaultAsync(p => p.PhotoId == photoId);
        var photoNew = await RepositoryContext.Photos.FirstOrDefaultAsync(p => p.PhotoId == photoIdNew);
        if (articleEntity != null)
        {
            articleEntity.Photos.Remove(photoOld);
            articleEntity.Photos.Add(photoNew);
        }
    }
    public async Task DeletePhotoByArticle(Guid artcleId, Guid photoId)
    {
        var articleEntity = RepositoryContext.Articles.Include(p => p.Photos).FirstOrDefault(a => a.ArticleId == artcleId);
        var photoIdEntity = await RepositoryContext.Photos.FirstOrDefaultAsync(p => p.PhotoId == photoId);

        articleEntity?.Photos.Remove(photoIdEntity);
    }
}
}
