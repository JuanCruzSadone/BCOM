using BCOM.API.Context;
using BCOM.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DB _db;

        public CustomerRepository(DB db)
        {
            _db = db;
        }

        public Customer GetCustomerById(int id)
        {
            var result = _db.Customer.FirstOrDefault(x => x.Id == id);

            return result;
        }

        public Customer CreateCustomer(Customer customer)
        {
            var result = _db.Customer.Add(customer);

            _db.SaveChanges();

            return result.Entity;
        }

        public List<Customer> GetCustomers()
        {
            var result = _db.Customer.ToList();

            return result;
        }

        public bool DeleteCustomer(int id)
        {
            var result = _db.Customer.FirstOrDefault(x => x.Id == id);

            if (result != null)
            {
                _db.Customer.Remove(result);
                _db.SaveChanges();
            }

            return true;
        }

        public Customer UpdateCustomer(int id, Customer customer)
        {
            _db.Entry(customer).State = EntityState.Modified;
            _db.SaveChanges();
            var result = _db.Customer.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public Customer GetCustomerByDni(int dni)
        {
            var result = _db.Customer.FirstOrDefault(x => x.Dni == dni);
            return result;
        }
    }
}
