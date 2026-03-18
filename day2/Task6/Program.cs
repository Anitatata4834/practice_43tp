namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLower(c))
                    result += char.ToUpper(c);
                else if (char.IsUpper(c))
                    result += char.ToLower(c);
                else
                    result += c;
            }
            Console.WriteLine("Результат: " + result);
        }
    }
}
