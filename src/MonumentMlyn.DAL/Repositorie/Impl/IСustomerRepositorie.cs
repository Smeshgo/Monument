using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    public interface IСustomerRepositorie :  IRepositoryBase<Customer>
    {
        Task<IEnumerable<Customer>> GetAllСustomers(bool trackChanges);
        Task<Customer> GetСustomerById(int idСustomer);
        Customer GetСustomerWithDetails(int idСustomer);
        void CreateAttachment(Customer customer);
        void UpdateСustomer(Customer customer);
        void DeleteСustomer(Customer customer);
    }
}