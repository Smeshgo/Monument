using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface IWorkerServices
    {
        Task<IEnumerable<WorkerDto>> GetAllWorkers();
        Task<WorkerDto> GetEmployeeById(int idWorker);
        Task CreateWorker(WorkerDto worker);
        Task UpdateWorker(int idWorker, WorkerDto worker);
        Task DeleteWorker(int idWorker);
    }
}