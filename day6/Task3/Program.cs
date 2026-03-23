namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserLoginManager manager = new UserLoginManager();
            SecuritySystem security = new SecuritySystem();
            NotificationService notify = new NotificationService();
            manager.UserLoggedIn += security.CheckAccess;
            manager.UserLoggedIn += notify.SendNotification;
            manager.Login("Anita");
        }
    }
}
