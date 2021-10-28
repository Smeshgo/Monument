using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO.Article
{
    public class ArticleRequest
    {
        public ArticleRequest()
        {
            
        }

        public ArticleRequest(Guid articleId, Guid photoId, Guid photoIdOld, string title, string contents)
        {
            ArticleId = articleId;
            PhotoId = photoId;
            PhotoIdOld = photoIdOld;
            Title = title;
            Contents = contents;
        }

        public Guid ArticleId { get; set; }
        public Guid PhotoId { get; set; }
        public Guid PhotoIdOld { get; set; }

        public string Title { get; set; }
        public string Contents { get; set; }

    }
}
