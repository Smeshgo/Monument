using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Services
{
    public interface IWorkerServices
    {
        Task<IEnumerable<WorkerDto>> GetAllWorkers();
        Task<WorkerDto> GetWorkerById(Guid idWorker);
        Task CreateWorker(WorkerRequest worker);
        Task UpdateWorker(Guid idWorker, WorkerRequest worker);
        Task DeleteWorker(Guid idWorker);
        Task AddSalary(Guid idWorker, SalaryRequest calculations);
        Task<IEnumerable<WorkerDto>> GetAllSalaryByWorkers();
        Task<IEnumerable<WorkerDto>> GetSalaryByWorkerById(Guid workerId);
        Task DeleteSalaryByDate(Guid workerId, DateTime dateSalary);
        Task<IEnumerable<WorkerDto>> SearchSalaryFromStartAndEndDate(Guid workerId, SalaryRequest salary);
    }
}