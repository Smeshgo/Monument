using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IRoleRepositorie : IRepositoryBase<Role>
    {
        Task<IEnumerable<Role>> GetAllRole(bool trackChanges);
        Task<Role> GetRoleById(Guid idRole);
        Role GetRoleWithDetails(Guid idRole);
        void CreateRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
    }
}