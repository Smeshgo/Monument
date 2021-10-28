using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IMonumentRepositorie : IRepositoryBase<Monument>
    {
        Task<IEnumerable<Monument>> GetAllMonuments(bool trackChanges);
        Task<Monument> GetMonumentById(Guid aidMonument);
        Monument GetMonumentWithDetails(Guid idMonument);
        void CreateMonument(Monument monument);
        void UpdateMonument(Monument monument);
        void DeleteMonument(Monument monument);
        IEnumerable<Monument> GetAllMaterialByMonument();
        IEnumerable<Monument> GetMaterialByMonument(Guid monumentId);
        Task UpdateMaterialByMonument(Guid monumentId, Guid materialId, Guid materialIdNew);
        Task DeleteMaterialByMonument(Guid monumentId, Guid materialId);
        IEnumerable<Monument> GetAllWorkersByMonument();
        IEnumerable<Monument> GetWorkersByMonument(Guid monumentId);
        Task UpdateWorkerByMonument(Guid monumentId, Guid workerId, Guid workerIdNew);
        Task DeleteWorkerByMonument(Guid monumentId, Guid workerId);
    }
}