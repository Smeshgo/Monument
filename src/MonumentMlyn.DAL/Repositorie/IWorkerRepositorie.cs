using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IWorkerRepositorie : IRepositoryBase<Worker>
    {
        Task<IEnumerable<Worker>> GetAllWorkers(bool trackChanges);
        Task<Worker> GetWorkerById(int Worker);
        Worker GetWorkerWithDetails(int Worker);
        void CreateWorker(Worker Worker);
        void UpdateWorker(Worker Worker);
        void DeleteWorker(Worker Worker);
    }
}