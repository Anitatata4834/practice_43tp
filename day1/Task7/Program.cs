namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nЦикл for:");
            for (int i = B; i >= A; i--)
                Console.WriteLine(i * i * i);
            Console.WriteLine("\nЦикл while:");
            int j = B;
            while (j >= A)
            {
                Console.WriteLine(j * j * j);
                j--;
            }
            Console.WriteLine("\nЦикл do-while:");
            int k = B;
            do
            {
                Console.WriteLine(k * k * k);
                k--;
            }
            while (k >= A);
        }
    }
}
