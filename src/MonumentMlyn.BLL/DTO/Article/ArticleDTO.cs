using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class ArticleDto
    {
        public ArticleDto()
        {


        }
        public ArticleDto(Guid articleId, string title, string contents, DateTime createArticle, DateTime updateArticle)
        {
            this.ArticleId = articleId;
            this.Title = title;
            this.Contents = contents;
            this.CreateArticle = createArticle;
            this.UpdateArticle = updateArticle;
        }
        public Guid ArticleId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? CreateArticle { get; set; }
        public DateTime? UpdateArticle { get; set; }
    }
}
