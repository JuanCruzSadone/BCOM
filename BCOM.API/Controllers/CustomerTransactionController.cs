using System;
using System.Collections.Generic;
using BCOM.API.Entities;
using BCOM.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BCOM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerTransactionController : Controller
    {
        private readonly ICustomerTransactionService _customerTransactionService;

        public CustomerTransactionController(ICustomerTransactionService customerTransactionService)
        {
            _customerTransactionService = customerTransactionService;
        }

        /// <summary>
        /// Get all customerTransactions.
        /// </summary>
        [HttpGet]
        public ActionResult<List<CustomerTransaction>> Get()
        {
            var result = _customerTransactionService.GetCustomerTransactions();
            return result;
        }

        /// <summary>
        /// Get customerTransaction by given Id
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<CustomerTransaction> Get(int id)
        {
            var result = _customerTransactionService.GetCustomerTransactionById(id);
            return result;
        }

        /// <summary>
        /// Creates a new customerTransaction.
        /// </summary>
        [HttpPost]
        public ActionResult Create([FromBody] CustomerTransaction customerTransaction)
        {
            try
            {
                var result = _customerTransactionService.CreateCustomerTransaction(customerTransaction);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Updates a customerTransaction.
        /// </summary>
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerTransaction customerTransaction)
        {
            var result = _customerTransactionService.UpdateCustomerTransaction(id, customerTransaction);
            return Ok(result);
        }

        /// <summary>
        /// Deletes a customerTransaction.
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _customerTransactionService.DeleteCustomerTransaction(id);
            return Ok();
        }

        /// <summary>
        /// Get customerTransaction by given Customer Id
        /// </summary>
        [HttpGet("getCustomerTransactionByCustomerId/{id}")]
        public ActionResult<List<CustomerTransaction>> GetCustomerTransactionByCustomerId(int id)
        {
            var result = _customerTransactionService.GetCustomerTransactionsByCustomerId(id);
            return result;
        }
    }
}

