using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task1
{
    public static class NotificationService
    {
        public static event Action<string> NotificationReceived;

        public static void Send(string message)
        {
            NotificationReceived?.Invoke(message);
        }
    }

}
