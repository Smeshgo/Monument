using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IRoleServices
    {
        Task<IEnumerable<RoleDto>> GetAllRoles();
        Task<RoleDto> GetERoleById(int idRole);
        Task CreateRole(RoleDto role);
        Task UpdateRole(int idRole, RoleDto role);
        Task DeleteRole(int idRole);
    }
}