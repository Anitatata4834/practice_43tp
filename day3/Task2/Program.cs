namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = ArrayGenerator.Generate(5);
            Console.WriteLine("Исходный массив:");
            foreach (double x in num)
                Console.WriteLine(x);
            ArraySort.Sort(num);
            Console.WriteLine("\nОтсортированный массив:");
            foreach (double x in num)
                Console.WriteLine(x);
            double[] filtered = ArrayFilter.FilterGreater(num, 5);
            Console.WriteLine("\nЭлементы > 5:");
            foreach (double x in filtered)
                Console.WriteLine(x);
            Console.WriteLine("\nСреднее значение: " + ArrayStats.Average(num));
            Console.WriteLine("Произведение элементов: " + ArrayStats.Product(num));
        }
    }
}
