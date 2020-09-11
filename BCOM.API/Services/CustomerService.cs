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

        public Customer CreateCustomer(Customer customer)
        {
            var result = _repo.CreateCustomer(customer);
            return result;
        }

        public Customer GetCustomerById(int id)
        {
            var result = _repo.GetCustomerById(id);

            return result;
        }

        public List<Customer> GetCustomers()
        {
            var result = _repo.GetCustomers();
            return result;
        }

        public bool DeleteCustomer(int id)
        {
            var result = _repo.DeleteCustomer(id);
            return result;
        }

        public Customer UpdateCustomer(int id, Customer customer)
        {
            var result = _repo.UpdateCustomer(id, customer);
            return result;
        }
    }
}
