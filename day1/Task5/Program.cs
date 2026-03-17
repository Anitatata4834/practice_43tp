namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;
            if (a == b && b == c)
                Console.WriteLine("Все цифры одинаковые");
            else
                Console.WriteLine("Цифры разные");
        }
    }
}
