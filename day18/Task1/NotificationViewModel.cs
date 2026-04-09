using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NotificationViewModel
    {
        public ObservableCollection<string> Notifications { get; set; } = new();

        public NotificationViewModel()
        {
            NotificationService.NotificationReceived += msg =>
            {
                App.Current.Dispatcher.Invoke(() =>
                {
                    Notifications.Add(msg);
                });
            };
        }
    }

}
