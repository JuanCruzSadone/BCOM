using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCOM.API.Entities;
using BCOM.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BCOM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Get all customers.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            var result = await _customerService.GetCustomers();
            return result;
        }

        /// <summary>
        /// Get customer by given Id
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(int id)
        {
            var result = await _customerService.GetCustomerById(id);
            return result;
        }

        /// <summary>
        /// Creates a new Customer.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Customer customer)
        {
            try
            {
                var result = await _customerService.CreateCustomer(customer);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Updates a customer.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Customer customer)
        {
            var result = await _customerService.UpdateCustomer(id, customer);
            return Ok(result);
        }

        /// <summary>
        /// Deletes a customer.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _customerService.DeleteCustomer(id);
            return Ok();
        }

        /// <summary>
        /// Get customer by given Dni
        /// </summary>
        [HttpGet("getCustomerByDni/{dni}")]
        public async Task<ActionResult<Customer>> GetCustomerByDni(int dni)
        {
            var result = await _customerService.GetCustomerByDni(dni);
            return result;
        }
    }
}

