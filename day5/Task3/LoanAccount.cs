using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class LoanAccount : BankAccount, ICreditAccount
    {
        public LoanAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }
        public void TakeLoan(decimal amount)
        {
            Balance -= amount;
        }
    }
}
