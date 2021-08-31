using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IMaterialServices
    {
        Task<IEnumerable<MaterialDto>> GetAllMaterials();
        Task<MaterialDto> GetMaterialById(Guid idMaterial);
        Task CreateMaterial(MaterialRequest material);
        Task UpdateMaterial(Guid idMaterial, MaterialRequest material);
        Task DeleteMaterial(Guid idMaterial);
    }
}