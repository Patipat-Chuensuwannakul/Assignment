using Assignment.Core.Domain.Base;
using Assignment.Core.DTO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Assignment.Core.Domain.Entities
{
    public class Customer : EntityBase<int>
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Email { get; set; }
        [StringLength(10)]
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