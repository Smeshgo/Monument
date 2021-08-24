using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.VisualBasic;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class WorkerServicesImpl : IWorkerServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public WorkerServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WorkerDto>> GetAllWorkers()
        {
            var workers =
                _mapper.Map<IEnumerable<Worker>, IEnumerable<WorkerDto>>(
                    await _repository.Worker.GetAllWorkers(trackChanges: false));

            return _mapper.Map<IEnumerable<WorkerDto>>(workers);
        }

        public async Task<WorkerDto> GetEmployeeById(Guid idWorker)
        {
            var worker = await _repository.Worker.GetWorkerById(idWorker);

            return _mapper.Map<WorkerDto>(worker);
        }

        public async Task CreateWorker(WorkerDto worker)
        {
            var workerEntity = _mapper.Map<Worker>(worker);

            _repository.Worker.CreateWorker(workerEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateWorker(Guid idWorker, WorkerDto worker)
        {
            var workerEntity = await _repository.Worker.GetWorkerById(idWorker);

            _mapper.Map(worker, workerEntity);
            _repository.Worker.UpdateWorker(workerEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteWorker(Guid idWorker)
        {
            var workerEntity =  await _repository.Worker.GetWorkerById(idWorker);

            _repository.Worker.DeleteWorker(workerEntity);
            await _repository.SaveAsync();
        }
    }
}