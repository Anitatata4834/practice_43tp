namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books =
        {
            new Book { Title="Война и мир", Author="Толстой", Pages=1200, Genre="Роман" },
            new Book { Title="Дюна", Author="Герберт", Pages=700, Genre="Фэнтези" },
            new Book { Title="Гарри Поттер", Author="Роулинг", Pages=500, Genre="Фэнтези" }
        };
            Library l = new Library(books);
            Console.WriteLine("Книга с наибольшим количеством страниц:");
            l.GetLongestBook().Print();
            Console.WriteLine("\nКниги жанра Фэнтези:");
            foreach (var b in l.GetBooksByGenre("Фэнтези"))
                b.Print();
        }
    }
}
