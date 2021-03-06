﻿using BCOM.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Services
{
    public interface ICustomerTransactionService
    {
        Task<CustomerTransaction> GetCustomerTransactionById(int id);

        Task<CustomerTransaction> CreateCustomerTransaction(CustomerTransaction customerTransaction);

        Task<List<CustomerTransaction>> GetCustomerTransactions();

        Task<bool> DeleteCustomerTransaction(int id);

        Task<CustomerTransaction> UpdateCustomerTransaction(int id, CustomerTransaction customerTransaction);

        Task<List<CustomerTransaction>> GetCustomerTransactionsByCustomerId(int id);

        Task<List<CustomerTransaction>> SearchByDate(SearchQuery query);
    }
}
