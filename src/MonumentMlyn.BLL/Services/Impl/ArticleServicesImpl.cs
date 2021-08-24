using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
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

        public async Task<ArticleDto> GetArticleById(Guid idArticle)
        {
            var article = await _repository.Article.GetArticleById(idArticle);

            return _mapper.Map<ArticleDto>(article);
        }

        public async Task CreateArticle(ArticleDto article)
        {
            var articleEntity = _mapper.Map<Article>(article);
            _repository.Article.CreateArticle(articleEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateArticle(Guid idArticle, ArticleDto article)
        {
            var articlEntity = await _repository.Article.GetArticleById(idArticle);

            _mapper.Map(article, articlEntity);
            _repository.Article.UpdateArticle(articlEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteArticle(Guid idArticle)
        {
            var articlEntity = await _repository.Article.GetArticleById(idArticle);
            _repository.Article.DeleteArticle(articlEntity);
            await _repository.SaveAsync();
        }
    }
}