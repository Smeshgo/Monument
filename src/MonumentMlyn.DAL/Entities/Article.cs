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
            
           
        }
        [Key]
        public Guid IdArticle { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? CreateArticle { get; set; }
        public DateTime? UpdateArticle { get; set; }

        public List<User> User { get; set; } = new List<User>();
        public List<Photo> Photo { get; set; } = new List<Photo>();
    }
}
