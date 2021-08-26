using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IRoleServices
    {
        Task<IEnumerable<RoleDto>> GetAllRoles();
        Task<RoleDto> GetRoleById(Guid idRole);
        Task CreateRole(RoleDto role);
        Task UpdateRole(Guid idRole, RoleDto role);
        Task DeleteRole(Guid idRole);
    }
}