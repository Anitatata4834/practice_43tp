namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[25];
            int[] b = new int[25];
            Random r = new Random();
            for (int i = 0; i < 25; i++)
            {
                a[i] = r.Next(-10, 11);
                b[i] = r.Next(-10, 11);
            }
            Console.WriteLine("Исходный массив В:");
            for (int i = 0; i < 25; i++)
                Console.Write(b[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < 25; i++)
            {
                if (b[i] > 0)
                    b[i] = b[i] * 10;
                else
                    b[i] = 0;
            }
            Console.WriteLine("Преобразованный массив В:");
            for (int i = 0; i < 25; i++)
                Console.Write(b[i] + " ");
            Console.WriteLine();
            Array.Sort(b);
            Console.WriteLine("Отсортированный массив В:");
            for (int i = 0; i < 25; i++)
                Console.Write(b[i] + " ");
            Console.WriteLine();
            Console.Write("Введите k для поиска: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int index = Array.BinarySearch(b, k);
            if (index >= 0)
                Console.WriteLine("Найдено в позиции " + index);
            else
                Console.WriteLine("Не найдено");
        }
    }
}
