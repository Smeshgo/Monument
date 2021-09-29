using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Article;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class ArticleServicesImpl : IArticleServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public ArticleServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ArticleDto>> GetAllArticles()
        {
            var article =
                _mapper.Map<IEnumerable<Article>, IEnumerable<ArticleDto>>(
                    await _repository.Article.GetAllArticles(trackChanges: false));

            return _mapper.Map<IEnumerable<ArticleDto>>(article);
        }

        public async Task<ArticleDto> GetArticleById(Guid articleId)
        {
            var article = await _repository.Article.GetArticleById(articleId);

            return _mapper.Map<ArticleDto>(article);
        }

        public async Task CreateArticle(ArticleRequest article)
        {
            var articleEntity = new Article()
            {
                ArticleId = Guid.NewGuid(),
                Title = article.Title,
                Contents = article.Contents,
                CreateArticle = DateTime.Now,
                UpdateArticle = DateTime.Now
            };

            _repository.Article.CreateArticle(articleEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateArticle(Guid articleId, ArticleRequest article)
        {
            var articleEntity = await _repository.Article.GetArticleById(articleId);

            articleEntity.Title = article.Title;
            articleEntity.Contents = article.Contents;
            articleEntity.UpdateArticle = DateTime.Now;

            _repository.Article.UpdateArticle(articleEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteArticle(Guid articleId)
        {
            var articleEntity = await _repository.Article.GetArticleById(articleId);
            _repository.Article.DeleteArticle(articleEntity);
            await _repository.SaveAsync();
        }

        public async Task CreateManyToMany(Guid articleid, Guid PhotoId)
        {
            var articleEntity = await _repository.Article.GetArticleById(articleid);

            var photoEntity = await _repository.Photo.GetPhotoById(PhotoId);

            articleEntity.Photos.Add(photoEntity);
            

            await _repository.SaveAsync();
        }
        
    }
}