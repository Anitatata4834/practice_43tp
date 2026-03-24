using System.Threading.Channels;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager manager = new UserManager();
            Console.Write("Введите роль пользователя для удаления: ");
            string role = Console.ReadLine();
            try
            {
                manager.DeleteUser(role);
            }
            catch (AdminDeletionException ex)
            {
                Console.WriteLine($"Ошибка удаления: {ex.Message}");
            }
        }
    }
}
