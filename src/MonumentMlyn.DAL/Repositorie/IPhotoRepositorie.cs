using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IPhotoRepositorie : IRepositoryBase<Photo>
    {
        Task<IEnumerable<Photo>> GetAllPhoto(bool trackChanges);
        Task<Photo> GetPhotoById(Guid PhotoId);
        Photo GetPhotoWithDetails(Guid PhotoId);
        void CreatePhoto(Photo photo);
        void UpdatePhoto(Photo photo);
        void DeletePhoto(Photo photo);
    }
}