using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TransactionProcessor
    {
        public List<Transaction> FilterByAmount(List<Transaction> transactions, decimal minAmount)
        {
            List<Transaction> result = new List<Transaction>();
            foreach (Transaction t in transactions)
            {
                if (t.Amount >= minAmount)
                    result.Add(t);
            }
            return result;
        }
    }
}
