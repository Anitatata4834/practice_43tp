using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NamedPipeChatServer
    {
        public async Task StartServer()
        {
            while (true)
            {
                using var server = new NamedPipeServerStream("DeptChatPipe", PipeDirection.InOut, 10);
                await server.WaitForConnectionAsync();

                byte[] buffer = new byte[256];
                int bytesRead = await server.ReadAsync(buffer, 0, buffer.Length);

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Получено сообщение: " + message);
            }
        }
    }
}
