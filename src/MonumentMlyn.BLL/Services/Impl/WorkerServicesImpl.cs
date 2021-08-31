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

        public async Task<WorkerDto> GetWorkerById(Guid idWorker)
        {
            var worker = await _repository.Worker.GetWorkerById(idWorker);

            return _mapper.Map<WorkerDto>(worker);
        }

        public async Task CreateWorker(WorkerRequest worker)
        {
            var workerEntity = new Worker()
            {
                IdWorker = Guid.NewGuid(),
                FirstName = worker.FirstName,
                NumberOfHours = worker.NumberOfHours,
                Rete = worker.Rete,
                Phone = worker.Phone,
                Salary = worker.Salary,
                LastName = worker.LastName,
                CreateWorcer = DateTime.Now,
                UpdateWorker = DateTime.Now
            };

            _repository.Worker.CreateWorker(workerEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateWorker(Guid idWorker, WorkerRequest worker)
        {
            var workerEntity = await _repository.Worker.GetWorkerById(idWorker);


            workerEntity.FirstName = worker.FirstName;
            workerEntity.NumberOfHours = worker.NumberOfHours;
            workerEntity.Rete = worker.Rete;
            workerEntity.Phone = worker.Phone;
            workerEntity.Salary = worker.Salary;
            workerEntity.LastName = worker.LastName;
            workerEntity.UpdateWorker = DateTime.Now;

            _repository.Worker.UpdateWorker(workerEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteWorker(Guid idWorker)
        {
            var workerEntity = await _repository.Worker.GetWorkerById(idWorker);

            _repository.Worker.DeleteWorker(workerEntity);
            await _repository.SaveAsync();
        }
    }
}