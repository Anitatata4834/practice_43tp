namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts =
            {
                new SavingsAccount("Анна", 1500),
                new LoanAccount("Вероника", -5000),
                new SavingsAccount("Дарья", 2000),
                new LoanAccount("Екатерина", -30000)
            };
            AccountLogic l = new AccountLogic();
            l.PrintAllCreditAccounts(accounts);
        }
    }
}
