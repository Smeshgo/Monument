using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class PhotoArticleDTO
    {
        public Guid IdPhoto { get; set; }
        public Guid IdArticle { get; set; }

        public virtual ArticleDTO IdArticleNavigation { get; set; }
        public virtual PhotoDTO IdPhotoNavigation { get; set; }
    }
}
