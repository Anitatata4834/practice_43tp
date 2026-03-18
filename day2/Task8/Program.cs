namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            double num;
            if (double.TryParse(text, out num))
                Console.WriteLine("Это корректное число с плавающей точкой");
            else
                Console.WriteLine("Это не корректное число с плавающей точкой");
        }
    }
}
