using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class ArticleUserDTO
    {
        public Guid IdArticle { get; set; }
        public Guid IdUser { get; set; }

        public virtual ArticleDTO IdArticleNavigationDto { get; set; }
        public virtual UserDTO IdUserNavigationDto { get; set; }
    }
}
