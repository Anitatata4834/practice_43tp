namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 1000;
            double normal = DiscountCalc.GetDiscount(price);
            double student = DiscountCalc.GetDiscount(price, true);
            Console.WriteLine("Цена со стандартной скидкой: " + normal);
            Console.WriteLine("Цена со студенческой скидкой: " + student);
        }
    }
}
