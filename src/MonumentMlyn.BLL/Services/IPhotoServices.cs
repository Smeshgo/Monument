using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IPhotoServices
    {
        Task<IEnumerable<PhotoDto>> GetAllPhotos();
        Task<PhotoDto> GetPhotoById(Guid PhotoId);
        Task<IEnumerable<PhotoDto>> GetAllMinyPhoto(int category);
        Task<IEnumerable<PhotoDto>> GetCategoryPhotos(int category);
        Task CreatePhoto(IFormFile imgFull, IFormFile imgMyni, string name, int category);
        Task UpdatePhoto(Guid PhotoId, PhotoRequest photo);
        Task DeletePhoto(Guid PhotoId);
    }
}