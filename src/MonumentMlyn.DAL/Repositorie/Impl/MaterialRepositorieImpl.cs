using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class MaterialRepositorieImpl : RepositoryBaseImpl<Material> , IMaterialRepositorie
    {
        public MaterialRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Material>> GetAllMaterial(bool trackChanges)=>
        await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

        public async Task<Material> GetMaterialtById(Guid idMaterial)
        {
            return await FindByCondition(x => x.IdMaterial.Equals(idMaterial))
                .FirstOrDefaultAsync();
        }

        public Material GetMaterialWithDetails(Guid idMaterial)
        {
            return FindByCondition(owner => owner.IdMaterial.Equals(idMaterial)).FirstOrDefault();
        }
        public void CreateMaterial(Material material)
        {
            Create(material);
        }
        public void UpdateMaterial(Material material)
        {
            Update(material);
        }
        public void DeleteMaterial(Material material)
        {
            Delete(material);
        }

        

       
    }
}