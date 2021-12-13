using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Paging;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Paging;

namespace MonumentMlyn.BLL.Services
{
    public interface IPhotoServices
    {
        Task<PagedList<Photo>> GetAllPhotos(OwnerParameters ownerParameters);
        Task<PhotoDto> GetPhotoById(Guid PhotoId);
        Task<PagedList<Photo>> GetAllMinyPhoto(int category, OwnerParameters ownerParameters);
        Task<IEnumerable<PhotoDto>> GetCategoryPhotos(int category);
        Task CreatePhoto(IFormFile imgFull, IFormFile imgMyni, string name, int category);
        Task UpdatePhoto(Guid id, IFormFile imgFull, IFormFile imgMini, string name, int category);
        Task DeletePhoto(Guid photoId);
    }
}