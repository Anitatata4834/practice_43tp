using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees;
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += MainWindow_KeyDown;

            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee { FullName = "Рощепкина А.О.", Position = "Программист" });
            Employees.Add(new Employee { FullName = "Токарева Е.А.", Position = "Архитектор" });
            Employees.Add(new Employee { FullName = "Савичева В.А.", Position = "Менеджер" });

            EmployeeList.ItemsSource = Employees;

        }
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.N)
            {
                AddEmployee_Click(null, null);  
            }
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.E)
            {
                EditEmployee_Click(null, null);  
            }
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.D)
            {
                DeleteEmployee_Click(null, null); 
            }
        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee selected = EmployeeList.SelectedItem as Employee;
            if (selected == null)
            {
                MessageBox.Show("Выберите сотрудника для редактирования");
                return;
            }
            EditEmployee ee = new EditEmployee(selected);
            if (ee.ShowDialog() == true)
            {
                selected.FullName = ee.FullName;
                selected.Position = ee.Position;
                EmployeeList.ItemsSource = null;
                EmployeeList.ItemsSource = Employees;
            }
        }

        private void FilterChanged(object sender, RoutedEventArgs e)
        {
            if (EmployeeList == null) return;
            RadioButton radio = sender as RadioButton;
            string filter = radio.Content.ToString();
            if (filter == "Все")
            {
                EmployeeList.ItemsSource = Employees;
                return;
            }
            List<Employee> filtered = new List<Employee>();
            foreach (Employee emp in Employees)
            {
                if (emp.Position == filter)
                {
                    filtered.Add(emp);
                }
            }
            EmployeeList.ItemsSource = filtered;
        }
        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            if (ae.ShowDialog() == true)
            {
                Employee emp = new Employee
                {
                    FullName = ae.FullName,
                    Position = ae.Position
                };
                Employees.Add(emp);
                EmployeeList.ItemsSource = null;
                EmployeeList.ItemsSource = Employees;
            }
        }
        private void DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee selected = EmployeeList.SelectedItem as Employee;
            if (selected == null)
            {
                MessageBox.Show("Выберите сотрудника для удаления");
                return;
            }
            MessageBoxResult result = MessageBox.Show(
                $"Удалить сотрудника:\n{selected.FullName} ({selected.Position})?",
                "Подтверждение удаления",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Employees.Remove(selected);
                EmployeeList.ItemsSource = null;
                EmployeeList.ItemsSource = Employees;
            }
        }
    }
}