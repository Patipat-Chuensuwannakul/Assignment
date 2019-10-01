using Assignment.Core.Domain.Entities;
using Assignment.Infrastructures.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Infrastructure.Repositories
{
    public interface ICustomerRepository: IRepository<Customer>
    {
        Customer GetById(int id);
        Customer GetByEmail(string email);
        Customer GetByIdAndEmail(int id, string email);
    }
}
