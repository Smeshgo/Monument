using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class CustomerServicesImpl : ICustomerServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public CustomerServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            var customers = _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(
                await _repository.Customer.GetAllСustomers(trackChanges: false));

            return _mapper.Map<IEnumerable<CustomerDto>>(customers);
        }

        public async Task<CustomerDto> GetCustomerById(Guid idСustomer)
        {
            var customer = await _repository.Customer.GetСustomerById(idСustomer);

            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task CreateCustomer(CustomerDto customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);

            _repository.Customer.CreateСustomer(customerEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateCustomer(Guid idCustomer, CustomerDto customer)
        {
            var customerEntity = await _repository.Customer.GetСustomerById(idCustomer);

            _mapper.Map(customer, customerEntity);
            _repository.Customer.UpdateСustomer(customerEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteCustomer(Guid idCustomer)
        {
            var customerEntity = await _repository.Customer.GetСustomerById(idCustomer);

            _repository.Customer.DeleteСustomer(customerEntity);
            await _repository.SaveAsync();
        }
    }
}