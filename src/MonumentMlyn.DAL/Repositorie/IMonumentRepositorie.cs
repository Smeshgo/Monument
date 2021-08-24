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
    }
}