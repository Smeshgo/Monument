using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.DAL.Repositorie
{
    class СustomerRepositorie: RepositoryBase<Customer>, IСustomerRepositorie
    {
        public СustomerRepositorie(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Customer>> GetAllСustomers(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(c => c.Last_name)
            .ToListAsync();
        public async Task<Customer> GetСustomerById(int idСustomer)
        {
            return await FindByCondition(x => x.id_customer.Equals(idСustomer))
                .FirstOrDefaultAsync();
        }

        public Customer GetСustomerWithDetails(int idСustomer)
        {
            return FindByCondition(owner => owner.id_customer.Equals(idСustomer)).FirstOrDefault();
        }

        public void CreateAttachment(Customer customer)
        {
            Create(customer);
        }

        public void UpdateСustomer(Customer customer)
        {
            Update(customer);
        }

        public void DeleteСustomer(Customer customer)
        {
            Delete(customer);
        }
    }
}
