using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie
{
    public class MaterialRepositorie : RepositoryBase<Material> , IMaterialRepositorie
    {
        public MaterialRepositorie(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Material>> GetAllMaterial(bool trackChanges)=>
        await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

        public async Task<Material> GetMaterialtById(int idMaterial)
        {
            return await FindByCondition(x => x.IdMaterial.Equals(idMaterial))
                .FirstOrDefaultAsync();
        }

        public Material GetMaterialWithDetails(int idMaterial)
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