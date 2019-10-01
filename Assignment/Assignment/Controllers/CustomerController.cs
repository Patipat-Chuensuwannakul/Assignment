using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.ActionFilters.Customer;
using Assignment.Core.Domain.Entities;
using Assignment.Core.DTO;
using Assignment.Core.Query;
using Assignment.Helpers;
using Assignment.Infrastructures.DAL.Services;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Infrastructure.Repositories;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<CustomerDTO>> Get()
        {
            return this.customerService.GetAllCustomer();
        }

        [HttpGet("GetById")]
        [ValidateGetById]
        public ActionResult<CustomerDTO> GetById(int customerId)
        {
            var customer = this.customerService.GetCustomerById(customerId);

            if (customer == null)
                return NotFound();

            return customer;
        }

        [HttpGet("GetByEmail")]
        [ValidateGetByEmail]
        public ActionResult<CustomerDTO> GetByEmail(string customerEmail)
        {
            var customer = this.customerService.GetCustomerByEmail(customerEmail);

            if (customer == null)
                return NotFound();

            return customer;
        }

        [HttpGet("GetByIdAndEmail")]
        [ValidateGetByIdAndEmail]
        public ActionResult<CustomerDTO> GetByIdAndEmail(int customerId, string customerEmail)
        {
            var customer = this.customerService.GetByCustomerIdAndEmail(customerId, customerEmail);

            if (customer == null)
                return NotFound();

            return customer;
        }
    }
}