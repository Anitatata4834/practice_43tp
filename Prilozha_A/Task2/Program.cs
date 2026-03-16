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
            int result = b * 10 + c;
            result = result * 10 + a;
            Console.WriteLine($"Полученное число: {result}");
        }
    }
}
