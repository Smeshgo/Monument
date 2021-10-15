using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public class SalaryRepositorieImpl :RepositoryBaseImpl<Salary>, ISalaryRepositorie
    {
        public SalaryRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Salary>> GetAllSalary(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Date)
                .ToListAsync();

        public async Task<Salary> GetSalaryById(Guid salaryId)
        {
            return await FindByCondition(x => x.WorkerId.Equals(salaryId))
                .FirstOrDefaultAsync();
        }

        public void CreateSalary(Salary calculations)
        {
            Create(calculations);
        }

        public void UpdateSalary(Salary calculations)
        {
            Update(calculations);
        }

        public void DeleteSalary(Salary calculations)
        {
            Delete(calculations);
        }
    }
}