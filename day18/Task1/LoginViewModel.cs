using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Task1
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly UserManager _userManager = new UserManager();

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            private get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private string _statusMessage;
        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand => new RelayCommand(Login);
        public ICommand RegisterCommand => new RelayCommand(Register);

        private void Login()
        {
            if (!_userManager.Authenticate(Username, Password))
            {
                StatusMessage = "Ошибка авторизации!";
                return;
            }

            MainWindow mw = new MainWindow(Username);
            mw.Show();

            foreach (Window w in Application.Current.Windows)
            {
                if (w is LoginView)
                {
                    w.Close();
                    break;
                }
            }
        }

        private void Register()
        {
            if (_userManager.RegisterUser(Username, Password))
                StatusMessage = "Регистрация успешна!";
            else
                StatusMessage = "Пользователь уже существует!";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

