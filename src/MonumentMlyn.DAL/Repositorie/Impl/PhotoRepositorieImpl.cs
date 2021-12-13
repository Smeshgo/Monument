using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO.Paging;
using MonumentMlyn.DAL.Paging;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class PhotoRepositorieImpl : RepositoryBaseImpl<Photo>, IPhotoRepositorie
    {
        public PhotoRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public PagedList<Photo> GetAllPhoto(OwnerParameters ownerParameters)
        {
            return PagedList<Photo>.ToPagedList(FindAll().OrderByDescending(on => on.UpdatePhoto),
                ownerParameters.PageNumber,
                ownerParameters.PageSize);
        }

        public async Task<IEnumerable<Photo>> GetAllMinyPhoto( int category, OwnerParameters ownerParameters)
        {

            return RepositoryContext.Photos
                .Where(c => (int)c.CategoryPhoto == category)
                .Skip((ownerParameters.PageNumber - 1) * ownerParameters.PageSize)
                .Take(ownerParameters.PageSize)
                .Select(s => new Photo()
                {
                    PhotoId = s.PhotoId,
                    Name = s.Name,
                    MinyPhoto = s.MinyPhoto,
                    CategoryPhoto = s.CategoryPhoto
                    
                });

        }
        public async Task<Photo> GetPhotoById(Guid photoId)
        {
            return await FindByCondition(x => x.PhotoId.Equals(photoId))
                .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Photo>> GetCategoryPhoto(int category)
        {
            var result = await FindAll()
                .Where(a => (int)a.CategoryPhoto == category)
           .OrderBy(c => c.Name)
           .ToListAsync();
            return result;
        }

        public Photo GetPhotoWithDetails(Guid photoId)
        {
            return FindByCondition(owner => owner.PhotoId.Equals(photoId)).FirstOrDefault();
        }

        public void CreatePhoto(Photo photo)
        {
            Create(photo);
        }

        public void UpdatePhoto(Photo photo)
        {
            Update(photo);
        }

        public void DeletePhoto(Photo photo)
        {
            Delete(photo);
        }
    }
}