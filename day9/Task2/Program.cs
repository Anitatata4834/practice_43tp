namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransactionFileWriter writer = new TransactionFileWriter();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Transaction t = new Transaction(id, amount);
                writer.AppendTransaction(t);
            }
            Console.WriteLine("Запись добавлена");
        }
    }
}
