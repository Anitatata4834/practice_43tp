using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public delegate void UserLoginHandler(string username);
    public class UserLoginManager
    {
        public event UserLoginHandler UserLoggedIn;
        public void Login(string username)
        {
            Console.WriteLine($"Пользователь {username} вошел в систему");
            UserLoggedIn?.Invoke(username);
        }
    }
}
