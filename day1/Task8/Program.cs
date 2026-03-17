namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int N = B - A + 1;
            for (int i = A; i <= B; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nКоличество N = " + N);
        }
    }
}
