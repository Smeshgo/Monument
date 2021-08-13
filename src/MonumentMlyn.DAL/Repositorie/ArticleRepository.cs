using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
        /// <summary>
        /// Method for get all employees from db.
        /// </summary>
        /// <param name="trackChanges">parameter that help in tracking changes.</param>
        /// <returns>list of all articles.</returns>
        public async Task<IEnumerable<Article>> GetAllArticles(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Title)
                .ToListAsync();

        /// <summary>
        /// Method for get idarticle by id from db.
        /// </summary>
        /// <param name="idarticle">id of Article.</param>
        /// <returns>get Article.</returns>
        public async Task<Article> GetArticleById(int idArticle)
        {
            return await FindByCondition(x => x.IdArticle.Equals(idArticle))
                .FirstOrDefaultAsync();
        }
        /// <summary>
        /// Method for get article with details from db.
        /// </summary>
        /// <param name="idarticle">id of article.</param>
        /// <returns>get article with details.</returns>
        public Article GetArticleWithDetails(int idArticle)
        {
            return FindByCondition(owner => owner.IdArticle.Equals(idArticle)).FirstOrDefault();
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
    }
}
