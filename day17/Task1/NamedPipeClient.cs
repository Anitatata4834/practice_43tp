using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NamedPipeChatClient
    {
        public async Task SendMessage(string message)
        {
            using var client = new NamedPipeClientStream(".", "DeptChatPipe", PipeDirection.Out);
            await client.ConnectAsync();

            byte[] buffer = Encoding.UTF8.GetBytes(message);
            await client.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}
