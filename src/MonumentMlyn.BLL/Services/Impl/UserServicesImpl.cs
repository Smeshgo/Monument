using System;
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

        public async Task<UserDto> GetUserById(Guid idUser)
        {
            var user = await _repository.User.GetUserById(idUser);

            return _mapper.Map<UserDto>(user);
        }

        public async Task CreateUser(UserRequest user)
        {
            var userEntity = new User()
            {
                UserId = Guid.NewGuid(),
                UserName = user.UserName,
                Password = user.Password,
                FirstName = user.Password,
                LastName = user.LastName,
                Email = user.Email,
                Status = user.Status,
                CreateUser = DateTime.Now,
                UpdateUser = DateTime.Now
            };

            _repository.User.CreateUser(userEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateUser(Guid idUser, UserRequest user)
        {
            var userEntity = await _repository.User.GetUserById(idUser);

            userEntity.UserName = user.UserName;
            userEntity.Password = user.Password;
            userEntity.FirstName = user.Password;
            userEntity.LastName = user.LastName;
            userEntity.Email = user.Email;
            userEntity.Status = user.Status;
            userEntity.UpdateUser = DateTime.Now;

            _repository.User.UpdateUser(userEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteUser(Guid idUser)
        {
            var userEntity = await _repository.User.GetUserById(idUser);

            _repository.User.DeleteUser(userEntity);
            await _repository.SaveAsync();
        }
    }
}