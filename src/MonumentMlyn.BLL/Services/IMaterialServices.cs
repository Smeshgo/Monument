using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IMaterialServices
    {
        Task<IEnumerable<MaterialDto>> GetAllMaterials();
        Task<MaterialDto> GetMaterialById(int idMaterial);
        Task CreateMaterial(MaterialDto material);
        Task UpdateMaterial(int idMaterial, MaterialDto material);
        Task DeleteMaterial(int idMaterial);
    }
}