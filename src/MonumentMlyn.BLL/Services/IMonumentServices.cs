using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IMonumentServices
    {
        Task<IEnumerable<MonumentDto>> GetAllMonuments();
        Task<MonumentDto> GetMonumentById(int idMonument);
        Task CreateMonument(MonumentDto monument);
        Task UpdateMonument(int idMonument, MonumentDto monument);
        Task DeleteMonument(int idMonument);
    }
}