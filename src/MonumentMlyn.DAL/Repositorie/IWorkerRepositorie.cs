using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IWorkerRepositorie : IRepositoryBase<Worker>
    {
        Task<IEnumerable<Worker>> GetAllWorkers(bool trackChanges);
        Task<Worker> GetWorkerById(Guid Worker);
        Worker GetWorkerWithDetails(Guid Worker);
        void CreateWorker(Worker Worker);
        void UpdateWorker(Worker Worker);
        void DeleteWorker(Worker Worker);
    }
}