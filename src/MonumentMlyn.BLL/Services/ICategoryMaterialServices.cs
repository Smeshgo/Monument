using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;


namespace MonumentMlyn.BLL.Services
{
    public interface ICategoryMaterialServices
    {
        Task<IEnumerable<CategoryMaterialDto>> GetAllCategoryMaterial();
        Task<CategoryMaterialDto> GetCategoryMaterialById(Guid idcategoryMaterial);
        Task CreateCategoryMaterial(CategoryMaterialDto categoryMaterial);
        Task UpdateCategoryMaterial(Guid idcategoryMaterial, CategoryMaterialDto categoryMaterial);
        Task DeleteCategoryMaterial(Guid idcategoryMaterial);
    }
}
