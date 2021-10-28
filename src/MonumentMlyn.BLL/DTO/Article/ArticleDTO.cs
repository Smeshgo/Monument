using System;
using System.Collections.Generic;
using MonumentMlyn.DAL.Entities;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class ArticleDto
    {
        public ArticleDto()
        {


        }

        public ArticleDto(Guid articleId, string title, string contents, DateTime? createArticle, DateTime? updateArticle)
        {
            ArticleId = articleId;
            Title = title;
            Contents = contents;
            CreateArticle = createArticle;
            UpdateArticle = updateArticle;
        }
        public Guid ArticleId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? CreateArticle { get; set; }
        public DateTime? UpdateArticle { get; set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();

        public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();

    }
}
