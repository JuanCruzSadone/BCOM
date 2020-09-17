using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCOM.API.Context;
using BCOM.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BCOM.API.Repositories
{
    public class CustomerTransactionRepository : ICustomerTransactionRepository
    {

        private readonly DB _db;

        public CustomerTransactionRepository(DB db)
        {
            _db = db;
        }

        public async Task<CustomerTransaction> CreateCustomerTransaction(CustomerTransaction customerTransaction)
        {
            var result = await _db.CustomerTransaction.AddAsync(customerTransaction);

            await _db.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<bool> DeleteCustomerTransaction(int id)
        {
            var result = await _db.CustomerTransaction.FirstOrDefaultAsync(x => x.Id == id);

            if (result != null)
            {
                _db.CustomerTransaction.Remove(result);
                await _db.SaveChangesAsync();
            }

            return true;
        }

        public async Task<CustomerTransaction> GetCustomerTransactionById(int id)
        {
            var result = await _db.CustomerTransaction.FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<List<CustomerTransaction>> GetCustomerTransactions()
        {
            var result = await _db.CustomerTransaction.Include(x => x.Customer).ToListAsync();

            return result;
        }

        public async Task<List<CustomerTransaction>> GetCustomerTransactionsByCustomerId(int id)
        {
            var result = await _db.CustomerTransaction.Where(x => x.IdCustomer == id).ToListAsync();

            return result;
        }

        public async Task<List<CustomerTransaction>> SearchByDate(SearchQuery query)
        {
            var result = await _db.CustomerTransaction.Where(x => x.TransactionDate >= query.DateFrom && x.TransactionDate <= query.DateTo).ToListAsync();

            return result;
        }

        public async Task<CustomerTransaction> UpdateCustomerTransaction(int id, CustomerTransaction customerTransaction)
        {
            _db.Entry(customerTransaction).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            var result = await _db.CustomerTransaction.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
    }
}
