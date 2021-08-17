using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface ICategoryPhotoRepositorie : IRepositoryBase<CategoryPhoto>
    {
        Task<IEnumerable<CategoryPhoto>> GetAllCategoryPhotos(bool trackChanges);
        Task<CategoryPhoto> GetCategoryPhotoById(int IdCategoryPhoto);
        CategoryPhoto GetCategoryPhotoWithDetails(int IdCategoryPhoto);
        void CreateCategoryPhoto(CategoryPhoto CategoryPhoto);
        void UpdateCategoryPhoto(CategoryPhoto CategoryPhoto);
        void DeleteCategoryPhoto(CategoryPhoto CategoryPhoto);
  
    }
}