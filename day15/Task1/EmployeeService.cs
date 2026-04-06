using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class EmployeeService
    {
        public ObservableCollection<EmployeeModel> LoadInitialEmployees()
        {
            return new ObservableCollection<EmployeeModel>
            {
            new EmployeeModel { FullName = "Рощепкина А.О.", Position = "Программист", Department = "IT" },
            new EmployeeModel { FullName = "Токарева Е.А.", Position = "Архитектор", Department = "Проектирование" },
            new EmployeeModel { FullName = "Савичева В.А.", Position = "Менеджер", Department = "Продажи" }
            };
        }

        public IEnumerable<EmployeeModel> Filter(ObservableCollection<EmployeeModel> employees, string position)
        {
            if (position == "Все")
                return employees;

            return employees.Where(e => e.Position == position);
        }
    }
}
