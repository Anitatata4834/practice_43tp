namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата: ");
            double a = double.Parse(Console.ReadLine());
            double p = 4 * a;
            Console.WriteLine("Периметр = " + p);
        }
    }
}
