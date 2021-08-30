using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO.CategoryMaterial
{
    public class CategoryMaterialRequest
    {
        public CategoryMaterialRequest()
        {
            
        }

        public CategoryMaterialRequest(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
