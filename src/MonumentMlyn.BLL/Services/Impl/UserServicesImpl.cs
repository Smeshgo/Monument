using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class UserServicesImpl : IUserServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public UserServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var users =
                _mapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(
                    await _repository.User.GetAllUsers(trackChanges: false));

            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<UserDto> GetUserById(int idUser)
        {
            var user = await _repository.User.GetUserById(idUser);

            return _mapper.Map<UserDto>(user);
        }

        public async Task CreateUser(UserDto user)
        {
            var userEntity = _mapper.Map<User>(user);

            _repository.User.CreateUser(userEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateUser(int idUser, UserDto user)
        {
            var userEntity = await _repository.User.GetUserById(idUser);

            _mapper.Map(user, userEntity);
            _repository.User.UpdateUser(userEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteUser(int idUser)
        {
            var userEntity = await _repository.User.GetUserById(idUser);

            _repository.User.DeleteUser(userEntity);
            await _repository.SaveAsync();
        }
    }
}