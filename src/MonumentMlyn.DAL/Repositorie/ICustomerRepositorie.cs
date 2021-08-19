using System.Collections.Generic;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface ICustomerRepositorie :  IRepositoryBase<Customer>
    {
        Task<IEnumerable<Customer>> GetAllСustomers(bool trackChanges);
        Task<Customer> GetСustomerById(int idСustomer);
        Customer GetСustomerWithDetails(int idСustomer);
        void CreateСustomer(Customer customer);
        void UpdateСustomer(Customer customer);
        void DeleteСustomer(Customer customer);
    }
}