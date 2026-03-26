using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Transaction(int id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}
