using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task1
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        private readonly NamedPipeChatClient _client = new NamedPipeChatClient();

        public string MessageText { get; set; }
        public ObservableCollection<string> Messages { get; set; } = new();

        public ICommand SendCommand => new RelayCommand(async () =>
        {
            if (string.IsNullOrWhiteSpace(MessageText))
                return;

            await _client.SendMessage(MessageText);

            Messages.Add("Вы: " + MessageText);

            string reply = GetDepartmentReply(MessageText);
            Messages.Add("Отдел: " + reply);

            MessageText = "";
            OnPropertyChanged(nameof(MessageText));
        });

        private readonly Random _rnd = new Random();

        private string GetDepartmentReply(string msg)
        {
            string[] replies =
            {
        "Архитектура слушает!",
        "Менеджер на месте",
        "Программист работает",
        "Документы уже в обработке",
        "Отдел занят, но ответит скоро!",
        "Мы приняли ваше сообщение.",
        "Информация уточняется.",
        "Отдел проверяет данные.",
        "Спасибо за обращение!",
        "Ожидайте, пожалуйста."
            };

            int index = _rnd.Next(replies.Length);
            return replies[index];
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
