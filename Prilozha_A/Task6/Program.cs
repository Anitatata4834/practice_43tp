namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2;
            double y = Math.Tan(Math.Sqrt(Math.Log(Math.Exp(x + 1)))) - (3 + Math.Sin(x * x)) / (Math.Sin(x * x) - Math.Cos(x * x));
            Console.WriteLine($"y = {y:F4}");
        }
    }
}
