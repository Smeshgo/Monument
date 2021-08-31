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


        public async Task<Role> GetRoleById(Guid idRole)
        {
            return await FindByCondition(x => x.IdRole.Equals(idRole))
                .FirstOrDefaultAsync();
        }

        public Role GetRoleWithDetails(Guid idRole)
        {
            return FindByCondition(owner => owner.IdRole.Equals(idRole)).FirstOrDefault();
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