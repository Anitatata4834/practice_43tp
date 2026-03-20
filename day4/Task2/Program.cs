namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цифру D1 (0–9): ");
            int D1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цифру D2 (0–9): ");
            int D2 = Convert.ToInt32(Console.ReadLine());
            Right.AddRightDigit(D1, ref K);
            Console.WriteLine("После добавления D1: " + K);
            Right.AddRightDigit(D2, ref K);
            Console.WriteLine("После добавления D2: " + K);
        }
    }
}
