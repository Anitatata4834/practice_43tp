namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToInt32(Console.ReadLine());
            double x = -b / (2 * a);
            double y = a * x * x + b * x + c;
            Console.WriteLine($"Вершина параболы: ({x}; {y})");
        }
    }
}
