using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IMaterialRepositorie : IRepositoryBase<Material>
    {
        Task<IEnumerable<Material>> GetAllMaterial(bool trackChanges);
        Task<Material> GetMaterialtById(int Material);
        Material GetMaterialWithDetails(int Material);
        void CreateMaterial(Material Material);
        void UpdateMaterial(Material Material);
        void DeleteMaterial(Material Material);
    }
}