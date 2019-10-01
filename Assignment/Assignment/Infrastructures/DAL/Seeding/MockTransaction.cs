﻿using Assignment.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructures.DAL.Seeding
{
    public static class MockTransaction
    {
        public static void CreateTransaction(AssignmentDbContext context)
        {
            if (context.Transactions.Any()) return;
            var mockTran1 = new Transaction()
            {
                Date = DateTime.Now,
                Amount = 123.4M,
                Currency = "USD",
                Status = TransactionStatus.Success,
                Customer = context.Customers.Where(c => c.Email == "test@test.com").SingleOrDefault(),
                CustomerId = context.Customers.Where(c => c.Email == "test@test.com").Select(x => x.Id).SingleOrDefault()
            };
            var mockTran2 = new Transaction()
            {
                Date = DateTime.Now,
                Amount = 456.7M,
                Currency = "THB",
                Status = TransactionStatus.Failed,
                Customer = context.Customers.Where(c => c.Email == "test@test.com").SingleOrDefault(),
                CustomerId = context.Customers.Where(c => c.Email == "test@test.com").Select(x => x.Id).SingleOrDefault()
            };


            context.Add(mockTran1);
            context.Add(mockTran2);
            context.SaveChanges();
        }
    }
}
