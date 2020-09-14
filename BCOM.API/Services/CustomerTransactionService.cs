using BCOM.API.Entities;
using BCOM.API.Repositories;
using System.Collections.Generic;


namespace BCOM.API.Services
{
    public class CustomerTransactionService : ICustomerTransactionService
    {

        private readonly ICustomerTransactionRepository _repo;

        public CustomerTransactionService(ICustomerTransactionRepository repo)
        {
            _repo = repo;
        }

        public CustomerTransaction CreateCustomerTransaction(CustomerTransaction customerTransaction)
        {
            var result = _repo.CreateCustomerTransaction(customerTransaction);
            return result;
        }

        public bool DeleteCustomerTransaction(int id)
        {
            var result = _repo.DeleteCustomerTransaction(id);
            return result;
        }

        public CustomerTransaction GetCustomerTransactionById(int id)
        {
            var result = _repo.GetCustomerTransactionById(id);

            return result;
        }

        public List<CustomerTransaction> GetCustomerTransactions()
        {
            var result = _repo.GetCustomerTransactions();
            return result;
        }

        public List<CustomerTransaction> GetCustomerTransactionsByCustomerId(int id)
        {
            var result = _repo.GetCustomerTransactionsByCustomerId(id);
            return result;
        }

        public List<CustomerTransaction> SearchByDate(SearchQuery query)
        {
            var result = _repo.SearchByDate(query);
            return result;
        }

        public CustomerTransaction UpdateCustomerTransaction(int id, CustomerTransaction customerTransaction)
        {
            var result = _repo.UpdateCustomerTransaction(id, customerTransaction);
            return result;
        }
    }
}
