using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class WorkerRepositorieImpl : RepositoryBaseImpl<Worker>, IWorkerRepositorie
    {
        public WorkerRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers() =>
            await FindAll()
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


        public IEnumerable<Worker> GetAllSalaryByWorkers()
        {
            var result = from worker in RepositoryContext.Workers
                         select new Worker
                         {
                             WorkerId = worker.WorkerId,
                             FirstName = worker.FirstName,
                             LastName = worker.LastName,
                             Phone = worker.Phone,
                             CreateWorker = worker.CreateWorker,
                             UpdateWorker = worker.UpdateWorker,
                             Salary = worker.Salary
                         };
            return result;
        }
        public IEnumerable<Worker> GetAllSalaryByWorkersById(Guid workerId)
        {
            var result = from worker in RepositoryContext.Workers.Where(a => a.WorkerId == workerId)
                         select new Worker
                         {
                             WorkerId = worker.WorkerId,
                             FirstName = worker.FirstName,
                             LastName = worker.LastName,
                             Phone = worker.Phone,
                             CreateWorker = worker.CreateWorker,
                             UpdateWorker = worker.UpdateWorker,
                             Salary = worker.Salary
                         };
            return result;
        }


        public void DeleteSalaryByDate(Guid workerId, DateTime dateSalary)
        {

            var salaryEntity = GetAllSalaryByWorkersById(workerId);
            foreach (var salary in salaryEntity)
            {
                foreach (var salaryDate in salary.Salary)
                {
                    if (salaryDate.Date == dateSalary)
                    {
                        var deleteSalary = salaryDate;
                        RepositoryContext.Salaries.Remove(deleteSalary);
                        break;
                    }
                }
            }

        }
        public IEnumerable<Worker> SearchSalaryFromStartAndEndDate(Guid workerId, DateTime startDate, DateTime endDate)
        {
            var salaryEntity = GetAllSalaryByWorkersById(workerId);

            var result = from worker in RepositoryContext.Workers.Where(a => a.WorkerId == workerId)
                select new Worker
                         {
                             WorkerId = worker.WorkerId,
                             FirstName = worker.FirstName,
                             LastName = worker.LastName,
                             Phone = worker.Phone,
                             CreateWorker = worker.CreateWorker,
                             UpdateWorker = worker.UpdateWorker,
                             Salary = (ICollection<Salary>)(from s in worker.Salary
                                                            where s.Date >= startDate && s.Date <= endDate
                                                            select s)
                         };
            return result;

        }
    }
}