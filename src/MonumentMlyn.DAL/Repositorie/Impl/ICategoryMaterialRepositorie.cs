using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface ICategoryMaterialRepositorie : IRepositoryBase<CategoryMaterial>
    {
        Task<IEnumerable<CategoryMaterial>> GetAllCategoryMaterial(bool trackChanges);
        Task<CategoryMaterial> GetCategoryMaterialById(int IdCategoryMaterial);
        CategoryMaterial GetCategoryMaterialWithDetails(int IdCategoryMaterial);
        void CreateCategoryMaterial(CategoryMaterial categoryMaterial);
        void UpdateCategoryMaterial(CategoryMaterial categoryMaterial);
        void DeleteCategoryMaterial(CategoryMaterial categoryMaterial);
    }
}