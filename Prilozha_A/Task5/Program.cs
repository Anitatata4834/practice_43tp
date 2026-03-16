namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;
            int product = a * b * c;
            Console.WriteLine($"Произведение цифр: {product}");
        }
    }
}
