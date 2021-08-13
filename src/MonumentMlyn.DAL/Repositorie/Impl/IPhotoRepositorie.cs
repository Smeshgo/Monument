using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IPhotoRepositorie : IRepositoryBase<Photo>
    {
        Task<IEnumerable<Photo>> GetAllPhoto(bool trackChanges);
        Task<Photo> GetPhotoById(int idPhoto);
        Photo GetPhotoWithDetails(int idPhoto);
        void CreatePhoto(Photo photo);
        void UpdatePhoto(Photo photo);
        void DeletePhoto(Photo photo);
    }
}