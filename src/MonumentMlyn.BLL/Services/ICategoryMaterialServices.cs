using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;


namespace MonumentMlyn.BLL.Services
{
    interface ICategoryMaterialServices
    {
        Task<IEnumerable<CategoryMaterialDto>> GetAllCategoryMaterial();
        Task<CategoryMaterialDto> GetCategoryMaterialById(int idcategoryMaterial);
        Task CreateCategoryMaterial(CategoryMaterialDto categoryMaterial);
        Task UpdateCategoryMaterial(int idcategoryMaterial, CategoryMaterialDto categoryMaterial);
        Task DeleteCategoryMaterial(int idcategoryMaterial);
    }
}
