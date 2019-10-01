using Assignment.Core.Domain.Entities;
using System.Collections.Generic;

namespace Assignment.Core.DTO
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public List<TransactionDTO> Transactions { get; set; }
    }
}
