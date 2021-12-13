using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO.Paging;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Paging;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IPhotoRepositorie : IRepositoryBase<Photo>
    {
        PagedList<Photo> GetAllPhoto(OwnerParameters ownerParameters);
        Task<Photo> GetPhotoById(Guid PhotoId);
        Task<IEnumerable<Photo>> GetAllMinyPhoto(int category, OwnerParameters ownerParameters);

        Task<IEnumerable<Photo>> GetCategoryPhoto(int category);
        Photo GetPhotoWithDetails(Guid PhotoId);
        void CreatePhoto(Photo photo);
        void UpdatePhoto(Photo photo);
        void DeletePhoto(Photo photo);
    }
}