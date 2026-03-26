using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public Transaction(int id, double amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}
