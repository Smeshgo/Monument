using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface ICategoryPhotoServices
    {
        Task<IEnumerable<CategoryPhotoDto>> GetAllCategoryPhoto();
        Task<CategoryPhotoDto> GetCategoryPhotoById(Guid idCategoryPhoto);
        Task CreateCategoryPhoto(CategoryPhotoDto categoryPhoto);
        Task UpdateCategoryPhoto(Guid idCategoryPhoto, CategoryPhotoDto categoryPhoto);
        Task DeleteCategoryPhoto(Guid idCategoryPhoto);
    }
}