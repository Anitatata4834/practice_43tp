namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;
            int sum = a + b + c;
            if (sum % 2 == 0)
                Console.WriteLine("Сумма цифр - четная");
            else
                Console.WriteLine("Сумма цифр - нечетная");
        }
    }
}
