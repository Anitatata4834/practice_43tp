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
        private EmployeeViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += MainWindow_KeyDown;

            _vm = new EmployeeViewModel();
            DataContext = _vm;

            EmployeeList.ItemsSource = _vm.Employees;

            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadingBar.Visibility = Visibility.Visible;
            EmployeeList.Visibility = Visibility.Collapsed;

            await _vm.LoadEmployeesAsync();

            LoadingBar.Visibility = Visibility.Collapsed;
            EmployeeList.Visibility = Visibility.Visible;
        }


        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.N)
                AddEmployee_Click(null, null);

            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.E)
                EditEmployee_Click(null, null);

            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.D)
                DeleteEmployee_Click(null, null);
        }

        private void FilterChanged(object sender, RoutedEventArgs e)
        {
            if (_vm == null)
                return;
            RadioButton radio = sender as RadioButton;
            string filter = radio.Content.ToString();

            EmployeeList.ItemsSource = _vm.Filter(filter);
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            if (ae.ShowDialog() == true)
            {
                _vm.AddEmployee(ae.FullName, ae.Position);
            }
        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModel selected = EmployeeList.SelectedItem as EmployeeModel;
            if (selected == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            EditEmployee ee = new EditEmployee(selected);
            if (ee.ShowDialog() == true)
            {
                _vm.EditEmployee(selected, ee.FullName, ee.Position);
            }
        }

        private void DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModel selected = EmployeeList.SelectedItem as EmployeeModel;
            if (selected == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            _vm.DeleteEmployee(selected);
        }

        private async void LoadEmployees_Click(object sender, RoutedEventArgs e)
        {
            LoadingBar.Visibility = Visibility.Visible;

            await _vm.LoadEmployeesAsync();

            LoadingBar.Visibility = Visibility.Collapsed;
        }
    }
}