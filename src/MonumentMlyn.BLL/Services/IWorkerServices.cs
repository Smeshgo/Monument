using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IWorkerServices
    {
        Task<IEnumerable<WorkerDto>> GetAllWorkers();
        Task<WorkerDto> GetWorkerById(Guid idWorker);
        Task CreateWorker(WorkerRequest worker);
        Task UpdateWorker(Guid idWorker, WorkerRequest worker);
        Task DeleteWorker(Guid idWorker);
    }
}