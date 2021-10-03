using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


        public IEnumerable<Monument> GetAllMaterialByMonument()
        {
            var monumentGetAllMaterial = RepositoryContext.Monuments
                .Include(m => m.Materials);
            return monumentGetAllMaterial;
        }
        public IEnumerable<Monument> GetMaterialByMonument(Guid monumentId)
        {
            var result =
                RepositoryContext.Monuments
                    .Include(a => a.Materials).Where(b => b.MonumentId == monumentId);
            return result;
        }

        public async Task UpdateMaterialByMonument(Guid monumentId, Guid materialId, Guid materialIdNew)
        {
            var monumentEntity = RepositoryContext.Monuments.Include(m => m.Materials)
                .FirstOrDefault(a => a.MonumentId == monumentId);
            var materialOld = await RepositoryContext.Materials.FirstOrDefaultAsync(m => m.MaterialId == materialId);
            var materialNew = await RepositoryContext.Materials.FirstOrDefaultAsync(m => m.MaterialId == materialIdNew);

            if (monumentEntity != null)
            {
                monumentEntity.Materials.Remove(materialOld);
                monumentEntity.Materials.Add(materialNew);
            }
        }

        public async Task DeleteMaterialByMonument(Guid monumentId, Guid materialId)
        {
            var monumentEntity = RepositoryContext.Monuments.FirstOrDefault(m => m.MonumentId == monumentId);
            var materialEntity = await RepositoryContext.Materials.FirstOrDefaultAsync(m => m.MaterialId == materialId);

            monumentEntity?.Materials.Remove(materialEntity);
        }
    }
}
