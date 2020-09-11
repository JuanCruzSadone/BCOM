using BCOM.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);

        List<Customer> GetCustomers();

        Customer CreateCustomer(Customer customer);

        bool DeleteCustomer(int id);

        Customer UpdateCustomer(int id, Customer customer);
    }
}
