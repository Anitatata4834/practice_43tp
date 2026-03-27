namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите способ аутентификации:");
            Console.WriteLine("1 - Basic");
            Console.WriteLine("2 - OAuth");
            Console.WriteLine("3 - JWT");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();
            IAuthStrategy strategy;
            if (choice == "1")
            {
                strategy = new BasicAuth();
                Console.Write("Введите имя: ");
                string username = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                AuthenticationService auth = new AuthenticationService(strategy);
                auth.AuthenticateUser(username, password);
            }
            else if (choice == "2")
            {
                strategy = new OAuthAuth();
                Console.Write("Введите имя: ");
                string username = Console.ReadLine();
                Console.Write("Введите токен: ");
                string password = Console.ReadLine();
                AuthenticationService auth = new AuthenticationService(strategy);
                auth.AuthenticateUser(username, password);
            }
            else
            {
                strategy = new JWTAuth();
                Console.Write("Введите имя: ");
                string username = Console.ReadLine();
                Console.Write("Введите токен: ");
                string password = Console.ReadLine();
                AuthenticationService auth = new AuthenticationService(strategy);
                auth.AuthenticateUser(username, password);
            }
        }
    }
}
