using BCOM.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Services
{
    public interface ICustomerTransactionService
    {
        CustomerTransaction GetCustomerTransactionById(int id);


        CustomerTransaction CreateCustomerTransaction(CustomerTransaction customerTransaction);


        List<CustomerTransaction> GetCustomerTransactions();


        bool DeleteCustomerTransaction(int id);


        CustomerTransaction UpdateCustomerTransaction(int id, CustomerTransaction customerTransaction);

        List<CustomerTransaction> GetCustomerTransactionsByCustomerId(int id);

        List<CustomerTransaction> SearchByDate(SearchQuery query);
    }
}
