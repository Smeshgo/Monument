using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IMonumentRepositorie : IRepositoryBase<Monument>
    {
        Task<IEnumerable<Monument>> GetAllMonuments(bool trackChanges);
        Task<Monument> GetMonumentById(int aidMonument);
        Monument GetMonumentWithDetails(int idMonument);
        void CreateMonument(Monument monument);
        void UpdateMonument(Monument monument);
        void DeleteMonument(Monument monument);
    }
}