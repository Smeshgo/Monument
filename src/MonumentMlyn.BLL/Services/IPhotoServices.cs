using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IPhotoServices
    {
        Task<IEnumerable<PhotoDto>> GetAllPhotos();
        Task<PhotoDto> GetPhotoById(int idPhoto);
        Task CreatePhoto(PhotoDto photo);
        Task UpdatePhoto(int idPhoto, PhotoDto photo);
        Task DeletePhoto(int idPhoto);
    }
}