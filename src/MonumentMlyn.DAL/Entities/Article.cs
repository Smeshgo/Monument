using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Article
    {
        public Article()
        {
            ArticleUsers = new HashSet<ArticleUser>();
            PhotoArticles = new HashSet<PhotoArticle>();
        }
        [Key]
        public Guid IdArticle { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? CreateArticle { get; set; }
        public DateTime? UpdateArticle { get; set; }

        public virtual ICollection<ArticleUser> ArticleUsers { get; set; }
        public virtual ICollection<PhotoArticle> PhotoArticles { get; set; }
    }
}
