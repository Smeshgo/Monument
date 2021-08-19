using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
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

        public async Task<MonumentDto> GetMonumentById(int idMonument)
        {
            var monument = await _repository.Monument.GetMonumentById(idMonument);

            return _mapper.Map<MonumentDto>(monument);
        }

        public async Task CreateMonument(MonumentDto monument)
        {
            var monumentEntity = _mapper.Map<Monument>(monument);

            _repository.Monument.CreateMonument(monumentEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateMonument(int idMonument, MonumentDto monument)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(idMonument);

            _mapper.Map(monument, monumentEntity);
            _repository.Monument.UpdateMonument(monumentEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteMonument(int idMonument)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(idMonument);

            _repository.Monument.DeleteMonument(monumentEntity);
            await _repository.SaveAsync();
        }
    }
}