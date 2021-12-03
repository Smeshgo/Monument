using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    class CustomerRepositorieImpl: RepositoryBaseImpl<Customer>, ICustomerRepositorie
    {
        public CustomerRepositorieImpl(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Customer>> GetAllСustomers() =>
        await FindAll()
            .OrderBy(c => c.LastName)
            .ToListAsync();
        public async Task<Customer> GetСustomerById(Guid customerId)
        {
            return await FindByCondition(x => x.CustomerId.Equals(customerId))
                .FirstOrDefaultAsync();
        }

        public Customer GetСustomerWithDetails(Guid customerId)
        {
            return FindByCondition(owner => owner.CustomerId.Equals(customerId)).FirstOrDefault();
        }

        public void CreateСustomer(Customer customer)
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
