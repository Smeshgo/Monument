using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonumentMlyn.BLL.DTO;

namespace MonumentMlyn.BLL.Services
{
    public interface ICustomerServices
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomers();
        Task<CustomerDto> GetCustomerById(Guid idСustomer);
        Task CreateCustomer(CustomerDto customer);
        Task UpdateCustomer(Guid idCustomer, CustomerDto customer);
        Task DeleteCustomer(Guid idCustomer);
    }
}
