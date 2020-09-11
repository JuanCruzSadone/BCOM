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

        public CustomerTransaction CreateCustomerTransaction(CustomerTransaction customerTransaction)
        {
            var result = _db.CustomerTransaction.Add(customerTransaction);

            _db.SaveChanges();

            return result.Entity;
        }

        public bool DeleteCustomerTransaction(int id)
        {
            var result = _db.CustomerTransaction.FirstOrDefault(x => x.Id == id);

            if (result != null)
            {
                _db.CustomerTransaction.Remove(result);
                _db.SaveChanges();
            }

            return true;
        }

        public CustomerTransaction GetCustomerTransactionById(int id)
        {
            var result = _db.CustomerTransaction.FirstOrDefault(x => x.Id == id);

            return result;
        }

        public List<CustomerTransaction> GetCustomerTransactions()
        {
            var result = _db.CustomerTransaction.ToList();

            return result;
        }

        public List<CustomerTransaction> GetCustomerTransactionsByCustomerId(int id)
        {
            var result = _db.CustomerTransaction.Where(x => x.IdCustomer == id).ToList();

            return result;
        }

        public CustomerTransaction UpdateCustomerTransaction(int id, CustomerTransaction customerTransaction)
        {
            _db.Entry(customerTransaction).State = EntityState.Modified;
            _db.SaveChanges();
            var result = _db.CustomerTransaction.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
