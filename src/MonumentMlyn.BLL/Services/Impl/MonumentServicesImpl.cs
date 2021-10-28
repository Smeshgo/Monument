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
                Price = monument.Price,
                PhotoId = monument.PhotoId,
                CustomerId = monument.CustomerId
            };

            _repository.Monument.CreateMonument(monumentEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateMonument(Guid idMonument, MonumentRequest monument)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(idMonument);

            monumentEntity.Price = monument.Price;
            monumentEntity.PhotoId = monument.PhotoId;
            monumentEntity.CustomerId = monument.CustomerId;


            _repository.Monument.UpdateMonument(monumentEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteMonument(Guid idMonument)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(idMonument);

            _repository.Monument.DeleteMonument(monumentEntity);
            await _repository.SaveAsync();
        }
        // Material
        public async Task AddMaterial(Guid monumentId, Guid materialId)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(monumentId);

            var materialEntity = await _repository.Material.GetMaterialtById(materialId);

            monumentEntity.Materials.Add(materialEntity);
            _repository.Monument.UpdateMonument(monumentEntity);

            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<MonumentDto>> GetAllMaterialByMonument()
        {
            var result = _repository.Monument.GetAllMaterialByMonument();

            return _mapper.Map<IEnumerable<MonumentDto>>(result);
        }

        public async Task<IEnumerable<MonumentDto>> GetMaterialByMonument(Guid monumentId)
        {
            var result = _repository.Monument.GetMaterialByMonument(monumentId);
            return _mapper.Map<IEnumerable<MonumentDto>>(result);
        }

        public async Task UpdateMaterialByMonument(Guid monumentId, MonumentRequest monument)
        {
            await _repository.Monument.UpdateMaterialByMonument(monumentId, monument.MaterialIdOld, monument.MaterialId);
            await _repository.SaveAsync();
        }

        public async Task DeleteMaterialByMonument(Guid monumentId, MonumentRequest monument)
        {
            await _repository.Monument.DeleteMaterialByMonument(monumentId, monument.MaterialId);
            await _repository.SaveAsync();
        }

        //Worker
        public async Task AddWorker(Guid monumentId, Guid workerId)
        {
            var monumentEntity = await _repository.Monument.GetMonumentById(monumentId);

            var workerEntity = await _repository.Worker.GetWorkerById(workerId);

            monumentEntity.Workers.Add(workerEntity);
            _repository.Monument.UpdateMonument(monumentEntity);

            await _repository.SaveAsync();
        }
        public async Task<IEnumerable<MonumentDto>> GetAllWorkerByMonument()
        {
            var result = _repository.Monument.GetAllWorkersByMonument();

            return _mapper.Map<IEnumerable<MonumentDto>>(result);
        }
        public async Task<IEnumerable<MonumentDto>> GetWorkerByMonument(Guid monumentId)
        {
            var result = _repository.Monument.GetWorkersByMonument(monumentId);
            return _mapper.Map<IEnumerable<MonumentDto>>(result);
        }
        public async Task UpdateWorkerByMonument(Guid monumentId, MonumentRequest monument)
        {
            await _repository.Monument.UpdateWorkerByMonument(monumentId, monument.WorkerIdOld, monument.WorkerId);
            await _repository.SaveAsync();
        }
        public async Task DeleteWorkerByMonument(Guid monumentId, MonumentRequest monument)
        {
            await _repository.Monument.DeleteWorkerByMonument(monumentId, monument.WorkerId);
            await _repository.SaveAsync();
        }
    }
}