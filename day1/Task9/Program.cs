namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0.5;
            double B = 1.0;
            int M = 10;
            double H = (B - A) / M;
            double x = A;
            for (int i = 0; i <= M; i++)
            {
                if (x > 1) x = 1;
                double y = Math.Acos(x);
                Console.WriteLine($"x = {x:F2}, y = {y:F6}");
                x = x + H;
            }
        }
    }
}
