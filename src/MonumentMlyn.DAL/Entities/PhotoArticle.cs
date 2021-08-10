using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class PhotoArticle
    {
        [Key]
        public Guid IdPhoto { get; set; }
        public Guid IdArticle { get; set; }

        public virtual Article IdArticleNavigation { get; set; }
        public virtual Photo IdPhotoNavigation { get; set; }
    }
}
