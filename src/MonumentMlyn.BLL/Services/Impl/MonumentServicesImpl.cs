using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.Monument;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class MonumentServicesImpl : IMonumentServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public MonumentServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MonumentDto>> GetAllMonuments()
        {
            var monuments =
                _mapper.Map<IEnumerable<Monument>, IEnumerable<MonumentDto>>(
                    await _repository.Monument.GetAllMonuments(trackChanges: false));

            return _mapper.Map<IEnumerable<MonumentDto>>(monuments);
        }

        public async Task<MonumentDto> GetMonumentById(Guid idMonument)
        {
            var monument = await _repository.Monument.GetMonumentById(idMonument);

            return _mapper.Map<MonumentDto>(monument);
        }

        public async Task CreateMonument(MonumentRequest monument)
        {
            var monumentEntity = new Monument()
            {
                MonumentId = Guid.NewGuid(),
                Price = monument.Prise,
                PhotoId = monument.PhotoId,
                CustomerId = monument.IdCustomer
            };

            _repository.Monument.CreateMonument(monumentEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateMonument(Guid idMonument, MonumentRequest monument)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(idMonument);

            monumentEntity.Price = monument.Prise;
            monumentEntity.PhotoId = monument.PhotoId;
            monumentEntity.CustomerId = monument.IdCustomer;


            _repository.Monument.UpdateMonument(monumentEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteMonument(Guid idMonument)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(idMonument);

            _repository.Monument.DeleteMonument(monumentEntity);
            await _repository.SaveAsync();
        }
    }
}