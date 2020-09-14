using BCOM.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);


        Customer CreateCustomer(Customer customer);


        List<Customer> GetCustomers();


        bool DeleteCustomer(int id);


        Customer UpdateCustomer(int id, Customer customer);

        Customer GetCustomerByDni(int dni);

    }
}
