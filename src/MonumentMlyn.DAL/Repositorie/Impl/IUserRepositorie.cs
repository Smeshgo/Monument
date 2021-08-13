using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IUserRepositorie : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> GetAllUsers(bool trackChanges);
        Task<User> GetUserById(int idUser);
        User GetUserWithDetails(int idUser);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}