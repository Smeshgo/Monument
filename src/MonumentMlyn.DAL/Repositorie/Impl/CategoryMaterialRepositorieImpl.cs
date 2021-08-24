using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class CategoryMaterialRepositorieImpl : RepositoryBaseImpl<CategoryMaterial>, ICategoryMaterialRepositorie
    {
        public CategoryMaterialRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
        /// <summary>
        /// Method for get all CategoryMaterials from db.
        /// </summary>
        /// <param name="trackChanges">parameter that help in tracking changes.</param>
        /// <returns>list of all CategoryMaterial.</returns>
        public async Task<IEnumerable<CategoryMaterial>> GetAllCategoryMaterial(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(c=>c.Name)
            .ToListAsync();

        /// <summary>
        /// Method for get idCategoryMaterial by id from db.
        /// </summary>
        /// <param name="idCategoryMaterial">id of CategoryMaterial.</param>
        /// <returns>get idCategoryMaterial.</returns>
        public async Task<CategoryMaterial> GetCategoryMaterialById(Guid IdCategoryMaterial)
        {
            return await FindByCondition(x => x.IdCategoryMaterial.Equals(IdCategoryMaterial))
                .FirstOrDefaultAsync();
        }
        /// <summary>
        /// Method for get CategoryMaterial with details from db.
        /// </summary>
        /// <param name="IdCategoryMaterial">id of CategoryMaterial.</param>
        /// <returns>get CategoryMaterial with details.</returns>
        public CategoryMaterial GetCategoryMaterialWithDetails(Guid idCategoryMaterial)
        {
            return FindByCondition(owner => owner.IdCategoryMaterial.Equals(idCategoryMaterial)).FirstOrDefault();
        }
        /// <summary>
        /// Method for create CategoryMaterial in db.
        /// </summary>
        /// <param name="CategoryMaterial">new CategoryMaterial.</param>
        public void CreateCategoryMaterial(CategoryMaterial CategoryMaterial)
        {
            Create(CategoryMaterial);
        }
        /// <summary>
        /// Method for categoryMaterial issue in db.
        /// </summary>
        /// <param name="categoryMaterial">categoryMaterial issue.</param>
        public void UpdateCategoryMaterial(CategoryMaterial categoryMaterial)
        {
            Update(categoryMaterial);
        }
        /// <summary>
        /// Method for searching categoryMaterial in db.
        /// </summary>
        /// <param name="categoryMaterial">search categoryMaterial.</param>
        /// <returns></returns>
        public void DeleteCategoryMaterial(CategoryMaterial categoryMaterial)
        {
            Delete(categoryMaterial);
        }
        
    }
}
