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
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private readonly string _currentUser;

        private readonly EmployeeRepository _repository;
        private readonly EmployeeService _service = new EmployeeService();

        public ObservableCollection<EmployeeModel> Employees { get; set; }
        public ObservableCollection<DepartmentModel> Departments { get; set; }

        private EmployeeModel _selectedEmployee;
        public EmployeeModel SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        public ICommand FireEmployeeCommand { get; }

        public EmployeeViewModel(string username)
        {
            _currentUser = username;

            Employees = new ObservableCollection<EmployeeModel>();

            Departments = new ObservableCollection<DepartmentModel>
            {
                new DepartmentModel { Id = 1, Name = "Продажи" },
                new DepartmentModel { Id = 2, Name = "ИТ" },
                new DepartmentModel { Id = 3, Name = "Маркетинг" }
            };

            _repository = new EmployeeRepository(new AppDbContext());

            FireEmployeeCommand = new RelayCommand(FireEmployee);
        }

        private async void FireEmployee()
        {
            if (SelectedEmployee == null)
                return;

            var toDelete = SelectedEmployee;

            Employees.Remove(toDelete);
            await _repository.DeleteEmployeeAsync(toDelete);

            NotificationService.Send("Удален сотрудник: " + toDelete.FullName);
        }

        public async Task LoadEmployeesAsync()
        {
            IsLoading = true;

            await Task.Delay(2000);

            var loaded = await _repository.GetEmployeesAsync(_currentUser);

            Employees.Clear();
            foreach (var emp in loaded)
            {
                Employees.Add(emp);
            }

            IsLoading = false;
        }

        public async void AddEmployee(string fullName, string position)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(position))
                return;

            var employee = new EmployeeModel
            {
                FullName = fullName,
                Position = position,
                UserName = _currentUser,
                DepartmentId = 1
            };

            await _repository.AddEmployeeAsync(employee);
            Employees.Add(employee);

            NotificationService.Send("Добавлен сотрудник: " + employee.FullName);
        }

        public async void EditEmployee(EmployeeModel selected, string fullName, string position)
        {
            if (selected == null)
                return;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(position))
                return;

            selected.FullName = fullName;
            selected.Position = position;

            await _repository.UpdateEmployeeAsync(selected);

            NotificationService.Send("Изменены данные сотрудника: " + selected.FullName);
        }

        public IEnumerable<EmployeeModel> Filter(string position)
        {
            return _service.Filter(Employees, position);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
