using BCOM.API.Entities;
using BCOM.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCOM.API.Services
{
    public class CustomerTransactionService : ICustomerTransactionService
    {

        private readonly ICustomerTransactionRepository _repo;

        public CustomerTransactionService(ICustomerTransactionRepository repo)
        {
            _repo = repo;
        }

        public async Task<CustomerTransaction> CreateCustomerTransaction(CustomerTransaction customerTransaction)
        {
            var result = await _repo.CreateCustomerTransaction(customerTransaction);
            return result;
        }

        public async Task<bool> DeleteCustomerTransaction(int id)
        {
            var result = await _repo.DeleteCustomerTransaction(id);
            return result;
        }

        public async Task<CustomerTransaction> GetCustomerTransactionById(int id)
        {
            var result = await _repo.GetCustomerTransactionById(id);

            return result;
        }

        public async Task<List<CustomerTransaction>> GetCustomerTransactions()
        {
            var result = await _repo.GetCustomerTransactions();
            return result;
        }

        public async Task<List<CustomerTransaction>> GetCustomerTransactionsByCustomerId(int id)
        {
            var result = await _repo.GetCustomerTransactionsByCustomerId(id);
            return result;
        }

        public async Task<List<CustomerTransaction>> SearchByDate(SearchQuery query)
        {
            var result = await _repo.SearchByDate(query);
            return result;
        }

        public async Task<CustomerTransaction> UpdateCustomerTransaction(int id, CustomerTransaction customerTransaction)
        {
            var result = await _repo.UpdateCustomerTransaction(id, customerTransaction);
            return result;
        }
    }
}
