using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class ArticleDTO
    {
        public ArticleDTO()
        {
            ArticleUsersDtos = new HashSet<ArticleUserDTO>();
            PhotoArticlesDtos = new HashSet<PhotoArticleDTO>();
        }

        public Guid IdArticle { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? CreateArticle { get; set; }
        public DateTime? UpdateArticle { get; set; }

        public virtual ICollection<ArticleUserDTO> ArticleUsersDtos { get; set; }
        public virtual ICollection<PhotoArticleDTO> PhotoArticlesDtos { get; set; }
    }
}
