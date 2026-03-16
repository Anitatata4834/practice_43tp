namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int product = a * b;
            Console.WriteLine($"{a} * {b} = {product}");
        }
    }
}
