using Assignment.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructures.DAL.Services
{
    public interface ICustomerService
    {
        List<CustomerDTO> GetAllCustomer();
        CustomerDTO GetCustomerByEmail(string email);
        CustomerDTO GetCustomerById(int id);
        CustomerDTO GetByCustomerIdAndEmail(int id, string email);
    }
}
