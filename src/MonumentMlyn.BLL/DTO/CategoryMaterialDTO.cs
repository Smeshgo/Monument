using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class CategoryMaterialDTO
    {
        public CategoryMaterialDTO()
        {
            MaterialsDTO = new HashSet<MaterialDTO>();
        }

        public Guid IdCategoryMaterial { get; set; }
        public string Name { get; set; }
        public DateTime? CreateCategoryMaterial { get; set; }

        public virtual ICollection<MaterialDTO> MaterialsDTO { get; set; }
    }
}
