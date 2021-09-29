using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class RoleRepositorieImpl : RepositoryBaseImpl<Role>,IRoleRepositorie
    {
        public RoleRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Role>> GetAllRole(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToListAsync();


        public async Task<Role> GetRoleById(Guid roleId)
        {
            return await FindByCondition(x => x.RoleId.Equals(roleId))
                .FirstOrDefaultAsync();
        }

        public Role GetRoleWithDetails(Guid roleId)
        {
            return FindByCondition(owner => owner.RoleId.Equals(roleId)).FirstOrDefault();
        }

        public void CreateRole(Role role)
        {
            Create(role );
        }

        public void UpdateRole(Role role)
        {
            Update(role);
        }

        public void DeleteRole(Role role)
        {
            Delete(role);
        }
    }
}