using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.DAL.Repositorie
{
    public class PhotoRepositorie : RepositoryBase<Photo>,IPhotoRepositorie
    {
        public PhotoRepositorie(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Photo>> GetAllPhoto(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToListAsync();
        public async Task<Photo> GetPhotoById(int idPhoto)
        {
            return await FindByCondition(x => x.IdPhoto.Equals(idPhoto))
                .FirstOrDefaultAsync();
        }

        public Photo GetPhotoWithDetails(int idPhoto)
        {
            return FindByCondition(owner => owner.IdPhoto.Equals(idPhoto)).FirstOrDefault();
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