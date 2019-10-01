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
            return assignmentDbContext.Customers.Include(cust => cust.Transactions);
        }
        public Customer GetById(int id)
        {
            return assignmentDbContext.Customers.Include(cust => cust.Transactions).Where(cust => cust.Id == id).SingleOrDefault();
        }

        public Customer GetByEmail(string email)
        {
            return assignmentDbContext.Customers.Include(cust => cust.Transactions).Where(cust => cust.Email == email).SingleOrDefault();
        }

        public Customer GetByIdAndEmail(int id, string email)
        {
            return assignmentDbContext.Customers.Include(x => x.Transactions).Where(cust => cust.Id == id && cust.Email == email).SingleOrDefault();
        }

    }
}
