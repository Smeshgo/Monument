using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Article
    {
        public Article()
        {
            
           
        }

        public Article(Guid idArticle, string title, string contents, DateTime? createArticle, DateTime? updateArticle)
        {
            IdArticle = idArticle;
            Title = title;
            Contents = contents;
            CreateArticle = createArticle;
            UpdateArticle = updateArticle;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdArticle { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? CreateArticle { get; set; }
        public DateTime? UpdateArticle { get; set; }

        public List<User> User { get; set; } = new List<User>();
        public List<Photo> Photo { get; set; } = new List<Photo>();
    }
}
