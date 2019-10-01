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
        public List<CustomerDTO> GetAllCustomer()
        {
            return this.customerRepository.GetAll().Select(_=>_.ToDTO())?.ToList();
        }

        public CustomerDTO GetCustomerByEmail(string email)
        {
            return this.customerRepository.GetByEmail(email)?.ToDTO();
        }

        public CustomerDTO GetCustomerById(int id)
        {
            return this.customerRepository.GetById(id)?.ToDTO();
        }

        public CustomerDTO GetByCustomerIdAndEmail(int id, string email)
        {
            return this.customerRepository.GetByIdAndEmail(id,email)?.ToDTO();
        }
    }
}
