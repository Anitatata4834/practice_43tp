namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[N, N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = r.Next(a, b + 1);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.Write("Введите номер столбца k: ");
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += arr[i, k];
            }
            Console.WriteLine("Сумма элементов столбца = " + sum);
            if (sum % m == 0)
                Console.WriteLine("Сумма кратна числу " + m);
            else
                Console.WriteLine("Сумма не кратна числу " + m);
        }
    }
}
