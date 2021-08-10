using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class ArticleUser
    {
        [Key]
        public Guid IdArticle { get; set; }
        public Guid IdUser { get; set; }
        
        public virtual Article IdArticleNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
