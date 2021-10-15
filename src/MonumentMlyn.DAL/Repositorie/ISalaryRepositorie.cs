using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface ISalaryRepositorie : IRepositoryBase<Salary>
    {
        Task<IEnumerable<Salary>> GetAllSalary(bool trackChanges);
        Task<Salary> GetSalaryById(Guid articleId);
        void CreateSalary(Salary calculations);
        void UpdateSalary(Salary calculations);
        void DeleteSalary(Salary calculations);
    }
}