using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class UserRepositorieImpl: RepositoryBaseImpl<User>, IUserRepositorie
    {
        public UserRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsers(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.LastName)
                .ToListAsync();

        public async Task<User> GetUserById(Guid userId)
        {
            return await FindByCondition(x => x.UserId.Equals(userId))
                .FirstOrDefaultAsync();
        }

        public User GetUserWithDetails(Guid userId)
        {
            return FindByCondition(owner => owner.UserId.Equals(userId)).FirstOrDefault();
        }

        public void CreateUser(User user)
        {
            Create(user);
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }
    }
}