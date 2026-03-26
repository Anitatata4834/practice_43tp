using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TransactionFileWriter
    {
        private string filePath = "file.data";
        public void AppendTransaction(Transaction transaction)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(transaction.Id + ";" + transaction.Amount);
            }
        }
    }
}
