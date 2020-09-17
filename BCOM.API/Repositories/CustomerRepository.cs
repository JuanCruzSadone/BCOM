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

        public async Task<Customer> GetCustomerById(int id)
        {
            var result = await _db.Customer.FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            var result = await _db.Customer.AddAsync(customer);

            await _db.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var result = await _db.Customer.ToListAsync();

            return result;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            var result = await _db.Customer.FirstOrDefaultAsync(x => x.Id == id);

            if (result != null)
            {
                _db.Customer.Remove(result);
                await _db.SaveChangesAsync();
            }

            return true;
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            _db.Entry(customer).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            var result = await _db.Customer.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Customer> GetCustomerByDni(int dni)
        {
            var result = await _db.Customer.FirstOrDefaultAsync(x => x.Dni == dni);
            return result;
        }
    }
}
