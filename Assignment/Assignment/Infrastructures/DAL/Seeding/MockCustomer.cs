using Assignment.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructures.DAL.Seeding
{
    public static class MockCustomer
    {
        public static void CreateCustomer(AssignmentDbContext context)
        {
            var customer1 = new Customer()
            {
                Email = "test1@test.com",
                Mobile = "0912224212",
                Name = "test test",
                Transactions = new List<Transaction>()
            };

            var customer2 = new Customer()
            {
                Email = "test2@test.com",
                Mobile = "0914356894",
                Name = "test2 manao",
                Transactions = new List<Transaction>()
            };

            var customer3 = new Customer()
            {
                Email = "test3@test.com",
                Mobile = "0914356895",
                Name = "test3 manao2",
                Transactions = new List<Transaction>()
            };


            context.Add(customer1);
            context.Add(customer2);
            context.Add(customer3);
            context.SaveChanges();
        }
    }
}
