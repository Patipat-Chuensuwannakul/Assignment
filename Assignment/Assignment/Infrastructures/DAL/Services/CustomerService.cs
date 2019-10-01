using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Core.DTO;
using WebAPI.Infrastructure.Repositories;

namespace Assignment.Infrastructures.DAL.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public List<CustomerDTO> GetAll()
        {
            return this.customerRepository.GetAll().Select(x=>x.ToDTO()).ToList();
        }

        public CustomerDTO GetById(int id)
        {
            return this.customerRepository.GetByCustomerId(id).ToDTO();
        }
    }
}
