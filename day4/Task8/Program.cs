namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            MinValueCalc.GetMinValue(in a, in b, out int minInt);
            double x = 2.5;
            double y = 1.5;
            MinValueCalc.GetMinValue(in x, in y, out double minDouble);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("minDouble = " + minDouble);
        }
    }
}
