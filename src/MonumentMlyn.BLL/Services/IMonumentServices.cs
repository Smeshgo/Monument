using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Monument;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IMonumentServices
    {
        Task<IEnumerable<MonumentDto>> GetAllMonuments();
        Task<MonumentDto> GetMonumentById(Guid idMonument);
        Task CreateMonument(MonumentRequest monument);
        Task UpdateMonument(Guid idMonument, MonumentRequest monument);
        Task DeleteMonument(Guid idMonument);
        Task AddMaterial(Guid monumentId, Guid materialId);
        Task<IEnumerable<MonumentDto>> GetAllMaterialByMonument();
        Task<IEnumerable<MonumentDto>> GetMaterialByMonument(Guid monumentId);
        Task UpdateMaterialByMonument(Guid monumentId, MonumentRequest monument);
        Task DeleteMaterialByMonument(Guid monumentId, MonumentRequest monument);
    }
}