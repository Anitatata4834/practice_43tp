namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N, но N < 10: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[N, N];
            Random r = new Random();
            for  (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = r.Next(a, b + 1);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            int product = 1;
            bool odd = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        product *= matrix[i, j];
                        odd = true;
                    }
                }
            }
            if (!odd)
                Console.WriteLine("Нечетных элементов нет");
            else
                Console.WriteLine("Произведение нечетных элементов " + product);
            Console.Write("Введите номер строки k: ");
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            int sum = 0;
            for (int j = 0; j < N; j++)
            {
                sum += matrix[k, j];
            }
            Console.WriteLine("Сумма элементов " + (k + 1) + " строки: " + sum);
        }
    }
}
