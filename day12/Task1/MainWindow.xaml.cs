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
        public List<Employee> Employees;
        public MainWindow()
        {
            InitializeComponent();

            Employees = new List<Employee>();

            Employees.Add(new Employee { FullName = "Рощепкина А.О.", Position = "Программист" });
            Employees.Add(new Employee { FullName = "Токарева Е.А.", Position = "Архитектор" });
            Employees.Add(new Employee { FullName = "Савичева В.А.", Position = "Менеджер" });

            EmployeeList.ItemsSource = Employees;
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
        private void EmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeeList.SelectedItem == null) return;
            Employee selected = (Employee)EmployeeList.SelectedItem;

            if (selected != null)
            {
                FullNameBox.Text = selected.FullName;
                PositionBox.Text = selected.Position;
            }
        } 
    }
}