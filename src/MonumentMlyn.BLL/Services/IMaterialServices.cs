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
        Task CreateMaterial(MaterialDto material);
        Task UpdateMaterial(Guid idMaterial, MaterialDto material);
        Task DeleteMaterial(Guid idMaterial);
    }
}