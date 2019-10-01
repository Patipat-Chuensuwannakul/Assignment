using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Core.Domain.Entities;
using Assignment.Core.DTO;
using Assignment.Core.Query;
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
            return this.customerService.GetAll();
        }

        [HttpGet("GetById")]
        public ActionResult<CustomerDTO> GetById(int customerId)
        {
            return this.customerService.GetById(customerId);
        }
    }
}