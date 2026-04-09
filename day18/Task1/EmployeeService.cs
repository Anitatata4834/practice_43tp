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
        public IEnumerable<EmployeeModel> Filter(ObservableCollection<EmployeeModel> employees, string position)
        {
            if (position == "Все")
                return employees;

            return employees.Where(e => e.Position == position);
        }
    }
}
