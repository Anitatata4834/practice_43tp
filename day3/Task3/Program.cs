namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books =
        {
            new FictionBook("Гарри Поттер", "Роулинг", 500),
            new NonFictionBook("Краткая история времени", "Хокинг", 300),
            new FictionBook("Фантастика", "Роулинг", 250)
        };
            Library l = new Library(books);
            var maxBook = l.GetMostPagesBook();
            Console.WriteLine($"Самая толстая книга: {maxBook.Title}");
            var rowlingBooks = l.GetBooksByAuthor("Роулинг");
            Console.WriteLine("Книги Роулинг:");
            foreach (var b in rowlingBooks)
                Console.WriteLine(b.Title);
        }
    }
}
