using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface ICategoryPhotoServices
    {
        Task<IEnumerable<CategoryPhotoDto>> GetAllCategoryPhoto();
        Task<CategoryPhotoDto> GetCategoryPhotoById(int idCategoryPhoto);
        Task CreateCategoryPhoto(CategoryPhotoDto categoryPhoto);
        Task UpdateCategoryPhoto(int idCategoryPhoto, CategoryPhotoDto categoryPhoto);
        Task DeleteCategoryPhoto(int idCategoryPhoto);
    }
}