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
        private EmployeeService _service;

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

        public EmployeeViewModel()
        {
            _service = new EmployeeService();

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

            await Task.Run(() =>
            {
                Task.Delay(2000).Wait();
            });

            var loaded = _service.LoadInitialEmployees();

            Employees.Clear();
            foreach (var emp in loaded)
            {
                Employees.Add(emp);
            }

            IsLoading = false;
        }

        public void AddEmployee(string fullName, string position)
        {
            Employees.Add(new EmployeeModel { FullName = fullName, Position = position });
        }

        public void EditEmployee(EmployeeModel emp, string newName, string newPosition)
        {
            emp.FullName = newName;
            emp.Position = newPosition;
        }

        public void DeleteEmployee(EmployeeModel emp)
        {
            Employees.Remove(emp);
        }

        public IEnumerable<EmployeeModel> Filter(string position)
        {
            return _service.Filter(Employees, position);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
