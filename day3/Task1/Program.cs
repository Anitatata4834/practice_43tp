namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A(4, 6);
            Console.WriteLine("a = " + obj.a);
            Console.WriteLine("b = " + obj.b);
            Console.WriteLine("Значение выражения: " + obj.Calc());
            Console.WriteLine("Квадрат разности: " + obj.DiffSquare());
        }
    }
}
