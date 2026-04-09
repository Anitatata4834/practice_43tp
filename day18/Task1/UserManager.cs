using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UserManager
    {
        private const string FilePath = "users.json";
        private List<UserModel> _users = new List<UserModel>();

        public UserManager()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                _users = JsonConvert.DeserializeObject<List<UserModel>>(json)
                         ?? new List<UserModel>();
            }
        }

        public void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(_users, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public bool RegisterUser(string username, string password)
        {
            if (_users.Exists(u => u.Username == username))
                return false;

            _users.Add(new UserModel
            {
                Username = username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password)
            });

            SaveUsers();
            return true;
        }

        public bool Authenticate(string username, string password)
        {
            var user = _users.Find(u => u.Username == username);
            return user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }
    }
}
