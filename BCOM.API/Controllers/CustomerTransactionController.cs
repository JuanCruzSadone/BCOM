using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<ActionResult<List<CustomerTransaction>>> Get()
        {
            var result = await _customerTransactionService.GetCustomerTransactions();
            return result;
        }

        /// <summary>
        /// Get customerTransaction by given Id
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerTransaction>> Get(int id)
        {
            var result = await _customerTransactionService.GetCustomerTransactionById(id);
            return result;
        }

        /// <summary>
        /// Creates a new customerTransaction.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CustomerTransaction customerTransaction)
        {
            try
            {
                var result = await _customerTransactionService.CreateCustomerTransaction(customerTransaction);
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
        public async Task<ActionResult> Put(int id, [FromBody] CustomerTransaction customerTransaction)
        {
            var result = await _customerTransactionService.UpdateCustomerTransaction(id, customerTransaction);
            return Ok(result);
        }

        /// <summary>
        /// Deletes a customerTransaction.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _customerTransactionService.DeleteCustomerTransaction(id);
            return Ok();
        }

        /// <summary>
        /// Get customerTransaction by given Customer Id
        /// </summary>
        [HttpGet("getCustomerTransactionByCustomerId/{id}")]
        public async Task<ActionResult<List<CustomerTransaction>>> GetCustomerTransactionByCustomerId(int id)
        {
            var result = await _customerTransactionService.GetCustomerTransactionsByCustomerId(id);
            return result;
        }

        /// <summary>
        /// Get customerTransaction by given dates
        /// </summary>
        [HttpPost("searchByDate/")]
        public async Task<ActionResult<List<CustomerTransaction>>> SearchByDate([FromBody] SearchQuery query)
        {
            var result = await _customerTransactionService.SearchByDate(query);
            return result;
        }
    }
}

