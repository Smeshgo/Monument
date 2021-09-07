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
        Task<PhotoDto> GetPhotoById(Guid idPhoto);
        Task CreatePhoto(PhotoRequest photo);
        Task UpdatePhoto(Guid idPhoto, PhotoRequest photo);
        Task DeletePhoto(Guid idPhoto);
    }
}