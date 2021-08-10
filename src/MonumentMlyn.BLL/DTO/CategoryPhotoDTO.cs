using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class CategoryPhotoDTO
    {
        public CategoryPhotoDTO()
        {
            Photos = new HashSet<PhotoDTO>();
        }

        public Guid IdCategoryPhoto { get; set; }
        public string Name { get; set; }
        public DateTime? CreatePhotoPhoto { get; set; }
        public DateTime? UpdateCategoryPhoto { get; set; }

        public virtual ICollection<PhotoDTO> Photos { get; set; }
    }
}
