using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class OAuthAuth : IAuthStrategy
    {
        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"OAuth-аутентификация: {username}, токен: {password}");
        }
    }
}
