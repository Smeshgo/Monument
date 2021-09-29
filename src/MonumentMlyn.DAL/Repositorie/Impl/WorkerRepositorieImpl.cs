using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class WorkerRepositorieImpl : RepositoryBaseImpl<Worker> , IWorkerRepositorie
    {
        public WorkerRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.LastName)
                .ToListAsync();
        public async Task<Worker> GetWorkerById(Guid workerId)
        {
            return await FindByCondition(x => x.WorkerId.Equals(workerId))
                .FirstOrDefaultAsync();
        }

        public Worker GetWorkerWithDetails(Guid workerId)
        {
            return FindByCondition(owner => owner.WorkerId.Equals(workerId)).FirstOrDefault();
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