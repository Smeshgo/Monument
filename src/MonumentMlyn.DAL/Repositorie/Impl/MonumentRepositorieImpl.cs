using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    class MonumentRepositorieImpl : RepositoryBaseImpl<Monument>, IMonumentRepositorie
    {
        public MonumentRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Monument>> GetAllMonuments(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Price)
                .ToListAsync();

        public async Task<Monument> GetMonumentById(Guid monumentId)
        {
            return await FindByCondition(x => x.MonumentId.Equals(monumentId))
                .FirstOrDefaultAsync();
        }

        public Monument GetMonumentWithDetails(Guid monumentId)
        {
            return FindByCondition(owner => owner.MonumentId.Equals(monumentId)).FirstOrDefault();
        }
        public void CreateMonument(Monument monument)
        {
            Create(monument);
        }
        public void UpdateMonument(Monument monument)
        {
            Update(monument);
        }

        public void DeleteMonument(Monument monument)
        {
            Delete(monument);
        }

       

        
    }
}
