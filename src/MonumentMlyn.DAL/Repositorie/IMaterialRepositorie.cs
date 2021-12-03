using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IMaterialRepositorie : IRepositoryBase<Material>
    {
        Task<IEnumerable<Material>> GetAllMaterial();
        Task<Material> GetMaterialtById(Guid Material);
        Material GetMaterialWithDetails(Guid Material);
        void CreateMaterial(Material Material);
        void UpdateMaterial(Material Material);
        void DeleteMaterial(Material Material);
    }
}