using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UserManager
    {
        public void DeleteUser(string role)
        {
            if (role == "Admin")
            {
                throw new AdminDeletionException("Нельзя удалить пользователя с ролью Admin");
            }
            Console.WriteLine($"Пользователь с ролью {role} успешно удален");
        }
    }
}
    