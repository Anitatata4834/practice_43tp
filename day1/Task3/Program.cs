namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите В: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            for (int i = A; i <= B; i++)
            {
                product *= i;
            }
            Console.WriteLine("Произведение = " + product);
        }
    }
}
