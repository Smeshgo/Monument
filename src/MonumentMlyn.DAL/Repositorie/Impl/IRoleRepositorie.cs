using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IRoleRepositorie : IRepositoryBase<Role>
    {
        Task<IEnumerable<Role>> GetAllRole(bool trackChanges);
        Task<Role> GetRoleById(int idRole);
        Role GetRoleWithDetails(int idRole);
        void CreateRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
    }
}