using Assignment.Core.Domain.Base;
using Assignment.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.Domain.Entities
{
    public class Customer : EntityBase<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public List<Transaction> Transactions { get; set; }

        public CustomerDTO ToDTO()
        {
            return new CustomerDTO()
            {
                CustomerID = Id,
                Name = Name,
                Email = Email,
                Mobile = Mobile,
                Transactions = Transactions.Select(x => x.ToDTO()).ToList()
            };
        }
    }
}