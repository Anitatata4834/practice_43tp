namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление площади треугольника");
            Console.WriteLine("Введите исходные данные:");
            Console.Write("Основание (см) —> ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Высота (см) -> ");
            double h = double.Parse(Console.ReadLine());
            double S = 0.5 * a * h;
            Console.WriteLine($"Площадь треугольника: {S:F2} кв.см.");
        }
    }
}
