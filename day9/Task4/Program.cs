namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к папке: ");
            string path = Console.ReadLine();
            FileWatcher fw = new FileWatcher(path);
            Console.WriteLine("Наблюдение запущено:");
            Console.ReadLine();
        }
    }
}
