using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.CategoryMaterial;


namespace MonumentMlyn.BLL.Services
{
    public interface ICategoryMaterialServices
    {
        Task<IEnumerable<CategoryMaterialDto>> GetAllCategoryMaterial();
        Task<CategoryMaterialDto> GetCategoryMaterialById(Guid id);
        Task CreateCategoryMaterial(CategoryMaterialRequest categoryMaterial);
        Task UpdateCategoryMaterial(Guid id, CategoryMaterialRequest categoryMaterial);
        Task DeleteCategoryMaterial(Guid id);
    }
}

