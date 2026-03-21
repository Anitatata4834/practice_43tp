using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class AccountLogic
    {
        public void PrintAllCreditAccounts(BankAccount[] accounts)
        {
            Console.WriteLine("Кредитные счета:");
            foreach (var account in accounts)
            {
                if (account is ICreditAccount)
                {
                    Console.WriteLine($"Владелец: {account.Owner}, баланс: {account.Balance}");
                }
            }
            Console.WriteLine();
        }
    }
}
