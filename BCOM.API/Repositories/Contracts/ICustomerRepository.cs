using BCOM.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerById(int id);

        Task<Customer> CreateCustomer(Customer customer);

        Task<List<Customer>> GetCustomers();

        Task<bool> DeleteCustomer(int id);

        Task<Customer> UpdateCustomer(int id, Customer customer);

        Task<Customer> GetCustomerByDni(int dni);
    }
}
