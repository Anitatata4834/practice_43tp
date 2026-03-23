namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            TimeFormatter timeFormatter = new TimeFormatter();
            DateFormatter dateFormatter = new DateFormatter();
            TimeHandler handler1 = timeFormatter.FormatTime;
            TimeHandler handler2 = dateFormatter.FormatDate;
            Console.WriteLine(handler1(now));
            Console.WriteLine(handler2(now));
        }
    }
}
