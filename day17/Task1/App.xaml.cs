using System.Configuration;
using System.Data;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NotificationViewModel Notifications;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var server = new NamedPipeChatServer();
            Task.Run(() => server.StartServer());
            Notifications = new NotificationViewModel();
        }

    }

}
