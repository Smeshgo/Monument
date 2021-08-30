using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class RoleServicesImpl : IRoleServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public RoleServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RoleDto>> GetAllRoles()
        {
            var roles =
                _mapper.Map<IEnumerable<Role>, IEnumerable<RoleDto>>(
                    await _repository.Role.GetAllRole(trackChanges: false));

            return _mapper.Map<IEnumerable<RoleDto>>(roles);
        }

        public async Task<RoleDto> GetRoleById(Guid idRole)
        {
            var role = await _repository.Role.GetRoleById(idRole);

            return _mapper.Map<RoleDto>(role);
        }

        public async Task CreateRole(RoleDto role)
        {
            var roleEntity = _mapper.Map<Role>(role);

            _repository.Role.CreateRole(roleEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateRole(Guid idRole, RoleDto role)
        {
            var roleEntity = await _repository.Role.GetRoleById(idRole);

            _mapper.Map(role, roleEntity);
            _repository.Role.UpdateRole(roleEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteRole(Guid idRole)
        {
            var roleEntity = await _repository.Role.GetRoleById(idRole);

            _repository.Role.DeleteRole(roleEntity);
            await _repository.SaveAsync();
        }
    }
}