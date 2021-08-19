using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    interface ICustomerServices
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomers(bool trackChanges);
        Task<CustomerDto> GetCustomerById(int idСustomer);
        Task CreateCustomer(CustomerDto customer);
        Task UpdateCustomer(int idCustomer, CustomerDto customer);
        Task DeleteCustomer(int idCustomer);
    }
}
