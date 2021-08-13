using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.DAL.Repositorie
{
    public class UserRepositorie: RepositoryBase<User>, IUserRepositorie
    {
        public UserRepositorie(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsers(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.LastName)
                .ToListAsync();

        public async Task<User> GetUserById(int idUser)
        {
            return await FindByCondition(x => x.IdUser.Equals(idUser))
                .FirstOrDefaultAsync();
        }

        public User GetUserWithDetails(int idUser)
        {
            return FindByCondition(owner => owner.IdUser.Equals(idUser)).FirstOrDefault();
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