using BCOM.API.Entities;
using BCOM.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            var result = await _repo.CreateCustomer(customer);
            return result;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            var result = await _repo.GetCustomerById(id);

            return result;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var result = await _repo.GetCustomers();
            return result;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            var result = await _repo.DeleteCustomer(id);
            return result;
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            var result = await _repo.UpdateCustomer(id, customer);
            return result;
        }

        public async Task<Customer> GetCustomerByDni(int dni)
        {
            var result = await _repo.GetCustomerByDni(dni);
            return result;
        }
    }
}
