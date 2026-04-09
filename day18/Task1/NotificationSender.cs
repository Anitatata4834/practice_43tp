using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NotificationSender
    {
        public void Send(string text)
        {
            MemoryMappedFile mmf = MemoryMappedFile.CreateNew("Notifications", 1024);
            using (var accessor = mmf.CreateViewAccessor())
            {
                byte[] data = Encoding.UTF8.GetBytes(text);
                accessor.WriteArray(0, data, 0, data.Length);
            }
        }
    }
}
