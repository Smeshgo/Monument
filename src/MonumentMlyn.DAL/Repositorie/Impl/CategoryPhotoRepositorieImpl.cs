using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    class CategoryPhotoRepositorieImpl : RepositoryBaseImpl<CategoryPhoto>, ICategoryPhotoRepositorie
    {
        public CategoryPhotoRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        /// <summary>
        /// Method for get all CategoryPhoto from db.
        /// </summary>
        /// <param name="trackChanges">parameter that help in tracking changes.</param>
        /// <returns>list of all CategoryPhoto.</returns>
        public async Task<IEnumerable<CategoryPhoto>> GetAllCategoryPhotos(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToListAsync();
        /// <summary>
        /// Method for get CategoryPhoto by id from db.
        /// </summary>
        /// <param name="CategoryPhoto">id of CategoryPhoto.</param>
        /// <returns>get CategoryPhoto.</returns>
        public async Task<CategoryPhoto> GetCategoryPhotoById(int IdCategoryPhoto)
        {
            return await FindByCondition(x => x.IdCategoryPhoto.Equals(IdCategoryPhoto))
                .FirstOrDefaultAsync();
        }
        /// <summary>
        /// Method for get CategoryPhoto with details from db.
        /// </summary>
        /// <param name="IdCategoryPhoto">id of CategoryPhoto.</param>
        /// <returns>get CategoryPhoto with details.</returns>
        public CategoryPhoto GetCategoryPhotoWithDetails(int idCategoryPhoto)
        {
            return FindByCondition(owner => owner.IdCategoryPhoto.Equals(idCategoryPhoto)).FirstOrDefault();
        }
        /// <summary>
        /// Method for create CategoryPhoto in db.
        /// </summary>
        /// <param name="categoryPhoto">new attachment.</param>
        public void CreateCategoryPhoto(CategoryPhoto categoryPhoto)
        {
            Create(categoryPhoto);
        }
        /// <summary>
        /// Method for update categoryPhoto in db.
        /// </summary>
        /// <param name="categoryPhoto">updated categoryPhoto.</param>
        public void UpdateCategoryPhoto(CategoryPhoto categoryPhoto)
        {
            Update(categoryPhoto);
        }

        public void DeleteCategoryPhoto(CategoryPhoto categoryPhoto)
        {
            Delete(categoryPhoto);
        }
    }
}
