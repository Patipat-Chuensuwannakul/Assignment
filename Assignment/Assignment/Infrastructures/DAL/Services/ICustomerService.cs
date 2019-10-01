using Assignment.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructures.DAL.Services
{
    public interface ICustomerService
    {
        List<CustomerDTO> GetAll();
        CustomerDTO GetById(int id);
    }
}
