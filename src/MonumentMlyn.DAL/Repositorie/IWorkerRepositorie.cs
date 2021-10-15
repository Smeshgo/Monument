﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IWorkerRepositorie : IRepositoryBase<Worker>
    {
        Task<IEnumerable<Worker>> GetAllWorkers(bool trackChanges);
        Task<Worker> GetWorkerById(Guid worker);
        Worker GetWorkerWithDetails(Guid worker);
        void CreateWorker(Worker worker);
        void UpdateWorker(Worker worker);
        void DeleteWorker(Worker worker);
        IEnumerable<Worker> GetAllSalaryByWorkers();
        IEnumerable<Worker> GetAllSalaryByWorkersById(Guid workerId);
        void DeleteSalaryByDate(Guid workerId, DateTime dateSalary);

    }
}