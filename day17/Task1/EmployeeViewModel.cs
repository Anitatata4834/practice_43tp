using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {

        private string _currentUser;
        private readonly EmployeeManager _manager = new EmployeeManager();
        private EmployeeManager _storage = new EmployeeManager();
        private readonly EmployeeService _service = new EmployeeService();

        public ObservableCollection<EmployeeModel> Employees { get; set; }
        public ObservableCollection<DepartmentModel> Departments { get; set; }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        public EmployeeViewModel(string username)
        {
            _currentUser = username;
            Employees = new ObservableCollection<EmployeeModel>();


            Departments = new ObservableCollection<DepartmentModel>
            {
                new DepartmentModel { Name = "IT" },
                new DepartmentModel { Name = "Продажи" },
                new DepartmentModel { Name = "Проектирование" }
            };
        }

        public async Task LoadEmployeesAsync()
        {
            IsLoading = true;

            await Task.Delay(2000);

            var loaded = _storage.Load();

            Employees.Clear();
            foreach (var emp in loaded)
                Employees.Add(emp);

            IsLoading = false;
            var all = _manager.Load();

            Employees.Clear();

            foreach (var emp in all.Where(e => e.UserName == _currentUser))
                Employees.Add(emp);
        }


        public void AddEmployee(string fullName, string position)
        {
            var employee = new EmployeeModel
            {
                FullName = fullName,
                Position = position,
                UserName = _currentUser
            };

            Employees.Add(employee);

            SaveAll();

            NotificationService.Send("Добавлен сотрудник: " + employee.FullName);

        }


        public void EditEmployee(EmployeeModel selected, string fullName, string position)
        {
            selected.FullName = fullName;
            selected.Position = position;
            SaveAll();
            var sender = new NotificationSender();
            NotificationService.Send("Изменены данные сотрудника: " + selected.FullName);

        }


        public void DeleteEmployee(EmployeeModel selected)
        {
            Employees.Remove(selected);
            SaveAll();
            NotificationService.Send("Удалён сотрудник: " + selected.FullName);

        }


        public IEnumerable<EmployeeModel> Filter(string position)
        {
            return _service.Filter(Employees, position);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        private void SaveAll()
        {
            var all = _manager.Load();

            all.RemoveAll(e => e.UserName == _currentUser);

            all.AddRange(Employees);

            _manager.Save(all);
        }

    }
}
