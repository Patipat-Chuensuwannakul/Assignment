using Assignment.Core.Domain.Entities;
using Assignment.Infrastructures.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AssignmentDbContext assignmentDbContext;
        public CustomerRepository(AssignmentDbContext assignmentDbContext)
        {
            this.assignmentDbContext = assignmentDbContext;
        }
        public IEnumerable<Customer> GetAll()
        {
            return assignmentDbContext.Customers.Include(x => x.Transactions);
        }
        public Customer GetById(int id)
        {
            return assignmentDbContext.Customers.Include(x => x.Transactions).SingleOrDefault(x => x.Id.Equals(id));
        }

        public Customer GetByEmail(string email)
        {
            return assignmentDbContext.Customers.Include(x => x.Transactions).SingleOrDefault(x => x.Email.Equals(email));
        }

        public Customer GetByIdAndEmail(int id, string email)
        {
            return assignmentDbContext.Customers.Include(x => x.Transactions).SingleOrDefault(x => x.Id.Equals(id) && x.Email.Equals(email));
        }
        public bool Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer item)
        {
            throw new NotImplementedException();
        }

    }
}
