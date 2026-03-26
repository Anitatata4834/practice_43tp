namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransactionFileReader reader = new TransactionFileReader();
            TransactionProcessor processor = new TransactionProcessor();
            List<Transaction> all = reader.ReadTransactions();
            Console.WriteLine("Введите минимальную сумму:");
            decimal min = Convert.ToDecimal(Console.ReadLine());
            List<Transaction> filtered = processor.FilterByAmount(all, min);
            Console.WriteLine("Результат фильтрации:");
            foreach (Transaction t in filtered)
            {
                Console.WriteLine("Id: " + t.Id + "  Amount: " + t.Amount);
            }
        }
    }
}
