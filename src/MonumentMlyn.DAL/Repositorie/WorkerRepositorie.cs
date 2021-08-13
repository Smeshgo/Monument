using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.DAL.Repositorie
{
    public class WorkerRepositorie : RepositoryBase<Worker> , IWorkerRepositorie
    {
        public WorkerRepositorie(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.LastName)
                .ToListAsync();
        public async Task<Worker> GetWorkerById(int idWorker)
        {
            return await FindByCondition(x => x.IdWorker.Equals(idWorker))
                .FirstOrDefaultAsync();
        }

        public Worker GetWorkerWithDetails(int idWorker)
        {
            return FindByCondition(owner => owner.IdWorker.Equals(idWorker)).FirstOrDefault();
        }

        public void CreateWorker(Worker worker)
        {
            Create(worker);
        }

        public void UpdateWorker(Worker worker)
        {
            Update(worker);
        }

        public void DeleteWorker(Worker worker)
        {
            Delete(worker);
        }
    }
}