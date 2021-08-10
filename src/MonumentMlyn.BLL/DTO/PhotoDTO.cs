using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class PhotoDTO
    {
        public PhotoDTO()
        {
            Monuments = new HashSet<MonumentDTO>();
            PhotoArticles = new HashSet<PhotoArticleDTO>();
        }

        public Guid IdPhoto { get; set; }
        public string Name { get; set; }
        public string PathFull { get; set; }
        public string PathMini { get; set; }
        public string Uuid { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }
        public Guid IdCategoryPhoto { get; set; }

        public virtual CategoryPhotoDTO IdCategoryPhotoNavigation { get; set; }
        public virtual ICollection<MonumentDTO> Monuments { get; set; }
        public virtual ICollection<PhotoArticleDTO> PhotoArticles { get; set; }
    }
}
