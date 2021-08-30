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

        public ArticleRequest(string title, string contents)
        {
            Title = title;
            Contents = contents;
        }
        public string Title { get; set; }
        public string Contents { get; set; }

    }
}
