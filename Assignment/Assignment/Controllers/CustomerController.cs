using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Core.Domain.Entities;
using Assignment.Core.DTO;
using Assignment.Core.Query;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Infrastructure.Repositories;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }


        [HttpGet("GetAll")]
        public ActionResult<List<Customer>> Get(int id)
        {
            return this.customerRepository.GetAll().ToList();
        }

        [HttpGet("GetById")]
        public ActionResult<CustomerDTO> GetById(int customerId, string email)
        {
            return new CustomerDTO()
            {
                CustomerID = 123456,
                Name = "Manao Test1",
                Email = "manaotest@domain.com",
                Mobile = "+66123456789",
                Transactions = new List<TransactionDTO>() {
                    new TransactionDTO() {
                        Date = DateTime.Now,
                        Amount = 1234.56M,
                        Currency = "USD",
                        Status = TransactionStatus.Success
                    }
                }
            };
        }


    }
}