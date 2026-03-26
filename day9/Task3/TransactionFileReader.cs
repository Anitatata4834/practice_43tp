using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TransactionFileReader
    {
        private string filePath = "D:\\Учеба\\2 КУРС\\КПиЯП\\Практика\\day9\\Task2\\bin\\Debug\\net8.0\\file.data";
        public List<Transaction> ReadTransactions()
        {
            List<Transaction> list = new List<Transaction>();
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден");
                return list;
            }
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                int id = Convert.ToInt32(parts[0]);
                decimal amount = Convert.ToDecimal(parts[1]);
                list.Add(new Transaction(id, amount));
            }
            return list;
        }
    }
}
