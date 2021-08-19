using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IUserServices
    {
        Task<IEnumerable<UserDto>> GetAllUsers();
        Task<UserDto> GetUserById(int idUser);
        Task CreateUser(UserDto user);
        Task UpdateUser(int idUser, UserDto user);
        Task DeleteUser(int idUser);
    }
}