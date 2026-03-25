namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальный размер очереди: ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            FixedQueueProcessor<int> processor = new FixedQueueProcessor<int>(capacity);
            Random r = new Random();
            for (int i = 0; i < capacity; i++)
            {
                int value = r.Next(1, 101); 
                processor.Add(value);
            }
            processor.Show();
            Console.Write("Введите число для поиска: ");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = processor.Find(search);
            if (found)
            {
                Console.WriteLine("Найдено");
            }
            else
            {
                Console.WriteLine("Не найдено");
            }
            Console.WriteLine("Сортируем очередь...");
            processor.Sort();
            processor.Show();
            Console.WriteLine("Удаляем первый элемент...");
            int removed = processor.Remove();
            Console.WriteLine("Итоговая очередь:");
            processor.Show();
        }
    }
}
