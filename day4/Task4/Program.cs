namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            Console.WriteLine(s.IsDigitsOnly());
            if (s.IsDigitsOnly())
                Console.WriteLine("Строка содержит только цифры");
            else
                Console.WriteLine("Строка содержит не только цифры");
        }
    }
}
