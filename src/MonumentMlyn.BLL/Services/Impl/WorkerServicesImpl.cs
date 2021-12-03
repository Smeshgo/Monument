using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
                    await _repository.Worker.GetAllWorkers());

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
                WorkerId = Guid.NewGuid(),
                FirstName = worker.FirstName,
                Phone = worker.Phone,
                LastName = worker.LastName,
                CreateWorker = DateTime.Now,
                UpdateWorker = DateTime.Now
            };

            _repository.Worker.CreateWorker(workerEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateWorker(Guid idWorker, WorkerRequest worker)
        {
            var workerEntity = await _repository.Worker.GetWorkerById(idWorker);

            workerEntity.FirstName = worker.FirstName;
            workerEntity.Phone = worker.Phone;
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



        public async Task<IEnumerable<WorkerDto>> GetAllSalaryByWorkers()
        {

            var workers = _repository.Worker.GetAllSalaryByWorkers();
            return _mapper.Map<IEnumerable<WorkerDto>>(workers);
        }
        public async Task<IEnumerable<WorkerDto>> GetSalaryByWorkerById(Guid workerid)
        {
            var workers = _repository.Worker.GetAllSalaryByWorkers().Where(a => a.WorkerId == workerid);

            return _mapper.Map<IEnumerable<WorkerDto>>(workers);
        }
        public async Task AddSalary(Guid idWorker, SalaryRequest calculations)
        {
            var workerEntity = await _repository.Worker.GetWorkerById(idWorker);

            var calculationEntity = new Salary()
            {   
                //WorkerId = workerEntity.WorkerId,
                Date = calculations.Date.Date,
                Advance = calculations.Advance,
                NumberOfHours = calculations.NumberOfHours,
                Rate = calculations.Rate
            };
            workerEntity.Salary.Add(calculationEntity);
           
            
            _repository.Worker.UpdateWorker(workerEntity);
            
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<WorkerDto>> SearchSalaryFromStartAndEndDate(Guid workerId, SalaryRequest salary)
        {
            var worker =  _repository.Worker.SearchSalaryFromStartAndEndDate(workerId, salary.Date, salary.DateOld);
            return _mapper.Map<IEnumerable<WorkerDto>>(worker);
        }

        public async Task DeleteSalaryByDate(Guid workerId, DateTime dateSalary)
        {
            _repository.Worker.DeleteSalaryByDate(workerId, dateSalary.Date);
            await _repository.SaveAsync();
        }


    }
}